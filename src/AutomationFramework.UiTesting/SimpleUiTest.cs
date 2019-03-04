using AutomationFramework.Config;
using AutomationFramework.Config.Enums;
using AutomationFramework.Config.Interfaces;
using AutomationFramework.Driver;
using AutomationFramework.Driver.Interfaces;
using AutomationFramework.PageObjects.Interfaces;
using AutomationFramework.PageObjects.Utilities;
using NUnit.Framework;

namespace AutomationFramework.UiTesting
{
    [TestFixture, Parallelizable]
    public abstract class SimpleUiTest
    {
        protected IAutomationDriver Driver;
        protected IWebPageFactory Factory;
        protected static IAutomationConfig Config;
        protected Browser DefaultBrowser = Browser.Chrome;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Config = AutomationConfig.DeserializeConfig("AutomationSettings.json");
        }

        [SetUp]
        public void SetUp()
        {
            Driver = new AutomationDriver(Config, DefaultBrowser);
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