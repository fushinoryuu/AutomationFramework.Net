using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Driver.Interfaces;
using System.Collections.Generic;

namespace AutomationFramework.PageObjects.Interfaces
{
    public interface IWebPage
    {
        IAutomationDriver Driver { get; set; }
        WebDriverWait Wait { get; set; }

        void WaitForPageToLoad();
        IWebElement FindElementBy(By by);
        IList<IWebElement> FindElementsBy(By by);
    }
}
