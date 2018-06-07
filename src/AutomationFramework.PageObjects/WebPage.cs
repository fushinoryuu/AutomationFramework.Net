using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AutomationFramework.Driver.Interfaces;
using AutomationFramework.PageObjects.Interfaces;

namespace AutomationFramework.PageObjects
{
    public abstract class WebPage : IWebPage
    {
        #region Properties

        public IAutomationDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }
        public IWebPageFactory Factory { get; set; }
        protected List<IWebElement> WebElements { get; set; } = new List<IWebElement>();

        #endregion

        #region Methods

        public virtual void WaitForPageToLoad()
        {
            const string errorMessage = "The 'WebElements' list is empty. You have to add web elements " +
                "to the list that you wish to use to check if a page has loaded.";

            if (WebElements.Count < 1)
                throw new InvalidOperationException(errorMessage);

            foreach (var element in WebElements)
                Wait.Until(func => element.Displayed && element.Enabled);
        }

        public IWebElement FindElementBy(By by) => Driver.FindElement(by);

        public IList<IWebElement> FindElementsBy(By by) => Driver.FindElements(by);

        public bool CheckPageForText(string text) => Driver.PageSource.Contains(text);

        /// <summary>
        /// This method should only be overwritten by a web page class that uses page section objects.
        /// </summary>
        public virtual void InitializePageSections() { }

        #endregion
    }
}
