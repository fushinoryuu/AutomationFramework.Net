using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Driver.Interfaces;
using PageObjects.Interfaces;
using System.Collections.Generic;

namespace PageObjects
{
    public abstract class WebPage : IWebPage
    {
        public IAutomationDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }

        public IWebElement FindElementBy(By by)
        {
            return Driver.FindElement(by);
        }

        public IList<IWebElement> FindElementsBy(By by)
        {
            return Driver.FindElements(by);
        }

        public abstract void WaitForPageToLoad();
    }
}
