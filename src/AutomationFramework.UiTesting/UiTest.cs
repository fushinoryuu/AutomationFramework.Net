using NUnit.Framework;
using AutomationFramework.Config;
using AutomationFramework.Driver;
using AutomationFramework.Config.Interfaces;
using AutomationFramework.Driver.Interfaces;
using AutomationFramework.PageObjects.Utilities;
using AutomationFramework.PageObjects.Interfaces;


namespace AutomationFramework.UiTesting
{
    [TestFixture, Parallelizable]
    public abstract class UiTest
    {
        protected IAutomationDriver Driver;
        protected IWebPageFactory Factory;
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
            Factory = new WebPageFactory(Driver);

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