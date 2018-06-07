using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using AutomationFramework.Driver.Interfaces;
using AutomationFramework.PageObjects.Interfaces;

namespace AutomationFramework.PageObjects
{
    public abstract class PageSection
    {
        #region Fields

        protected IAutomationDriver Driver;
        protected WebDriverWait Wait;
        protected IWebPageFactory Factory;
        protected List<IWebElement> WebElements;

        #endregion

        public PageSection (IAutomationDriver driver, WebDriverWait wait,
            IWebPageFactory factory, List<IWebElement> elementsList)
        {
            Driver = driver;
            Wait = wait;
            Factory = factory;
            WebElements = elementsList;
        }
    }
}
