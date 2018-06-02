using NUnit.Framework;
using AutomationFramework.Config;
using AutomationFramework.Config.Interfaces;
using AutomationFramework.Driver;
using AutomationFramework.Driver.Interfaces;
using AutomationFramework.Config.Enums;

namespace AutomationFramework.UiTesting
{
    [TestFixture, Parallelizable]
    public abstract class UiTest
    {
        protected IAutomationDriver Driver;
        protected static IAutomationConfig Config;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Config = AutomationConfig.DeserializeConfig("AutomationSettings.json");
        }

        [SetUp]
        public void SetUp()
        {
            Driver = new AutomationDriver(Config);

            var env = Config.ActiveEnvironment;

            Driver.Navigate().GoToUrl(Config.GetBaseUrl(env));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}