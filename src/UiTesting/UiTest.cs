using NUnit.Framework;
using AutomationConfig.Interfaces;
using Driver.Interfaces;
using Driver;

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
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}