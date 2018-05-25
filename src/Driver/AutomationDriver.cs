using System.Collections.ObjectModel;
using AutomationConfig.Interfaces;
using OpenQA.Selenium;
using Driver.Interfaces;

namespace Driver
{
    public class AutomationDriver : IAutomationDriver
    {
        private readonly IWebDriver Driver;
        private readonly IAutomationConfig Config;

        public AutomationDriver(IAutomationConfig config)
        {
            Config = config;
        }

        #region InheritedMethods

        public string Url { get => Driver.Url; set => Driver.Url = value; }

        public string Title => Driver.Title;

        public string PageSource => Driver.PageSource;

        public string CurrentWindowHandle => Driver.CurrentWindowHandle;

        public ReadOnlyCollection<string> WindowHandles => Driver.WindowHandles;

        public void Close() => Driver.Close();

        public void Dispose() => Driver.Dispose();

        public object ExecuteAsyncScript(string script, params object[] args) => ((IJavaScriptExecutor)Driver).ExecuteAsyncScript(script, args);

        public object ExecuteScript(string script, params object[] args) => ((IJavaScriptExecutor)Driver).ExecuteScript(script, args);

        public IWebElement FindElement(By by) => Driver.FindElement(by);

        public ReadOnlyCollection<IWebElement> FindElements(By by) => Driver.FindElements(by);

        public IOptions Manage() => Driver.Manage();

        public INavigation Navigate() => Driver.Navigate();

        public void Quit() => Driver.Quit();

        public ITargetLocator SwitchTo() => Driver.SwitchTo();

        #endregion
    }
}
