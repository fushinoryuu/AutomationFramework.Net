using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using AutomationFramework.Driver.Interfaces;
using AutomationFramework.PageObjects.Interfaces;

namespace AutomationFramework.PageObjects
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
