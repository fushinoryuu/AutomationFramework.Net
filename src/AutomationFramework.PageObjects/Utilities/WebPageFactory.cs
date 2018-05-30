using System;
using Driver.Interfaces;
using PageObjects.Interfaces;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework.PageObjects.Utilities
{
    public class WebPageFactory : IWebPageFactory
    {
        private IAutomationDriver _driver;

        public WebPageFactory(IAutomationDriver driver)
        {
            _driver = driver;
        }

        public T Get<T>() where T : IWebPage, new()
        {
            var instance = new T
            {
                Driver = _driver,
                Wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 30))
            };

            instance.WaitForPageToLoad();

            return instance;
        }

        public T Get<T>(TimeSpan customWait) where T : IWebPage, new()
        {
            var instance = new T
            {
                Driver = _driver,
                Wait = new WebDriverWait(_driver, customWait)
            };

            instance.WaitForPageToLoad();

            return instance;
        }
    }
}
