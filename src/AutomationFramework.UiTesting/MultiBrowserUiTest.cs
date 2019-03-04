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
    public abstract class MultiBrowserUiTest
    {
        protected IAutomationDriver Driver;
        protected IWebPageFactory Factory;
        protected static IAutomationConfig Config;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Config = AutomationConfig.DeserializeConfig("AutomationSettings.json");
        }

        public void SetupDriver(Browser currentBrowser)
        {
            Driver = new AutomationDriver(Config, currentBrowser);
            Factory = new WebPageFactory(Driver);

            var env = Config.ActiveEnvironment;
            var url = Config.GetBaseUrl(env);

            Driver.Navigate().GoToUrl(url);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}