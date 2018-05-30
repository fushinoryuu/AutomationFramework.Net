using NUnit.Framework;
using AutomationFramework.Config;
using AutomationFramework.Config.Interfaces;
using AutomationFramework.Driver;
using AutomationFramework.Driver.Interfaces;

namespace AutomationFramework.UiTesting
{
    [TestFixture, Parallelizable]
    public abstract class UiTest
    {
        protected IAutomationConfig Config;
        protected IAutomationDriver Driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Config = AutomationConfig.DeserializeConfig("AutomationSettings.json");
        }

        [SetUp]
        public void SetUp()
        {
            Driver = new AutomationDriver(Config);

            Driver.Navigate().GoToUrl(Config.BaseUrl);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}