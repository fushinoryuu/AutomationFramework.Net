using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using AutomationFramework.PageObjects;
using AutomationFramework.SamplePages.Pages;
using AutomationFramework.SamplePages.Interfaces;
using AutomationFramework.Driver.Interfaces;
using AutomationFramework.PageObjects.Interfaces;

namespace AutomationFramework.SamplePages.Reusable
{
    internal class LoggedOutNavBar : PageSection, INavBar
    {
        #region WebElements

        protected IWebElement GitHubLogo => Driver.FindElement(By.ClassName("octicon"));
        protected IWebElement FeaturesLink => Driver.FindElement(By.CssSelector("a[href*='/features']"));
        protected IWebElement BusinessLink => Driver.FindElement(By.CssSelector("a[href*='/business']"));
        protected IWebElement ExploreLink => Driver.FindElement(By.CssSelector("a[href*='/explore']"));
        protected IWebElement MarketplaceLink => Driver.FindElement(By.CssSelector("a[href*='/marketplace']"));
        protected IWebElement PricingLink => Driver.FindElement(By.CssSelector("a[href*='/pricing']"));
        protected IWebElement SearchTextbox => Driver.FindElement(By.Name("q"));

        #endregion

        #region Initializers

        public LoggedOutNavBar(IAutomationDriver driver, WebDriverWait wait, IWebPageFactory factory,
            List<IWebElement> elementsList) : base(driver, wait, factory, elementsList)
        {
            WebElements.AddRange(
                new List<IWebElement>
                {
                    GitHubLogo, FeaturesLink, BusinessLink, ExploreLink,
                    MarketplaceLink, PricingLink, SearchTextbox
                });
        }

        #endregion

        #region Methods

        public IBusiness ClickBusinessLink()
        {
            BusinessLink.Click();

            return Factory.Get<BusinessPage>();
        }

        public IExplore ClickExploreLink()
        {
            ExploreLink.Click();

            return Factory.Get<ExplorePage>();
        }

        public IFeatures ClickFeaturesLink()
        {
            FeaturesLink.Click();

            return Factory.Get<FeaturesPage>();
        }

        public IHome ClickGitHubLogo()
        {
            GitHubLogo.Click();

            return Factory.Get<HomePage>();
        }

        public IMarketplace ClickMarketplaceLink()
        {
            MarketplaceLink.Click();

            return Factory.Get<MarketplacePage>();
        }

        public IPricing ClickPricingLink()
        {
            PricingLink.Click();

            return Factory.Get<PricingPage>();
        }

        public ISearchResults SearchGitHub(string querryString)
        {
            SearchTextbox.Click();
            SearchTextbox.Clear();
            SearchTextbox.SendKeys(querryString + Keys.Return);

            return Factory.Get<SearchResultsPage>();
        }

        #endregion
    }
}
