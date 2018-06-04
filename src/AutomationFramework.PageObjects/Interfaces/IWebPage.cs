using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using AutomationFramework.Driver.Interfaces;

namespace AutomationFramework.PageObjects.Interfaces
{
    public interface IWebPage
    {
        IAutomationDriver Driver { get; set; }
        WebDriverWait Wait { get; set; }
        IWebPageFactory Factory { get; set; }

        void WaitForPageToLoad();
        IWebElement FindElementBy(By by);
        IList<IWebElement> FindElementsBy(By by);
    }
}
