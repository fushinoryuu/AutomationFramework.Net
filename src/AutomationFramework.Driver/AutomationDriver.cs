using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;
using AutomationFramework.Config.Enums;
using AutomationFramework.Driver.Interfaces;
using AutomationFramework.Config.Interfaces;
using OperatingSystem = AutomationFramework.Config.Enums.OperatingSystem;

namespace AutomationFramework.Driver
{
    public class AutomationDriver : IAutomationDriver
    {
        private readonly IWebDriver _driver;
        private readonly IAutomationConfig _config;
        private readonly Browser _browser;

        public AutomationDriver(IAutomationConfig config, Browser desiredBrowser)
        {
            _config = config;
            _browser = desiredBrowser;
            _driver = SetupWebDriver();

            _driver.Manage().Window.Maximize();
        }

        private IWebDriver SetupWebDriver()
        {
            if (_config.ActiveDriverLocation is DriverLocation.LocalDriver)
                return SetupLocalWebDriver();

            return SetupRemoteWebDriver();
        }

        private IWebDriver SetupLocalWebDriver()
        {
            throw new NotImplementedException();
        }

        private IWebDriver SetupRemoteWebDriver()
        {
            var driverOptions = DesiredBrowser();

            driverOptions.PlatformName = DesiredOS();

            var hubUrl = SeleniumHubLocation();

            return new RemoteWebDriver(hubUrl, driverOptions.ToCapabilities());
        }

        private DriverOptions DesiredBrowser()
        {
            switch (_browser)
            {
                case Browser.InternetExplorer:
                    return new InternetExplorerOptions();
                case Browser.Edge:
                    return new EdgeOptions();
                case Browser.FireFox:
                    return new FirefoxOptions();
                case Browser.Safari:
                    return new SafariOptions();
                case Browser.Chrome:
                default:
                    return new ChromeOptions();
            }
        }

        private string DesiredOS()
        {
            var os = _config.TargetOperatingSystem;

            switch (os)
            {
                case OperatingSystem.Linux:
                    return new Platform(PlatformType.Linux).ToString();
                case OperatingSystem.Mac:
                    return new Platform(PlatformType.Mac).ToString();
                case OperatingSystem.Windows:
                    return new Platform(PlatformType.Windows).ToString();
                case OperatingSystem.Any:
                default:
                    return new Platform(PlatformType.Any).ToString();
            }
        }

        private Uri SeleniumHubLocation()
        {
            var location = _config.ActiveDriverLocation;
            var url = _config.GetDriverLocation(location);

            return new Uri(url);
        }

        #region InheritedMethods

        public string Url { get => _driver.Url; set => _driver.Url = value; }

        public string Title => _driver.Title;

        public string PageSource => _driver.PageSource;

        public string CurrentWindowHandle => _driver.CurrentWindowHandle;

        public ReadOnlyCollection<string> WindowHandles => _driver.WindowHandles;

        public void Close() => _driver.Close();

        public void Dispose() => _driver.Dispose();

        public object ExecuteAsyncScript(string script, params object[] args) => ((IJavaScriptExecutor)_driver).ExecuteAsyncScript(script, args);

        public object ExecuteScript(string script, params object[] args) => ((IJavaScriptExecutor)_driver).ExecuteScript(script, args);

        public IWebElement FindElement(By by) => _driver.FindElement(by);

        public ReadOnlyCollection<IWebElement> FindElements(By by) => _driver.FindElements(by);

        public IOptions Manage() => _driver.Manage();

        public INavigation Navigate() => _driver.Navigate();

        public void Quit() => _driver.Quit();

        public ITargetLocator SwitchTo() => _driver.SwitchTo();

        #endregion
    }
}
