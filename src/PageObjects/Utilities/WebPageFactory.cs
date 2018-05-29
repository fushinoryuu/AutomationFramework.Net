using System;
using Driver.Interfaces;
using PageObjects.Interfaces;
using OpenQA.Selenium.Support.UI;

namespace PageObjects.Utilities
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
    }
}
