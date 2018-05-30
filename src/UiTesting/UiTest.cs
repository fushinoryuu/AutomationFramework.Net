using Driver;
using Driver.Interfaces;
using NUnit.Framework;
using AutomationConfig.Interfaces;

namespace UiTesting
{
    [TestFixture, Parallelizable]
    public abstract class UiTest
    {
        protected IAutomationConfig Config;
        protected IAutomationDriver Driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Config = AutomationConfig.AutomationConfig.DeserializeConfig("AutomationSettings.json");
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