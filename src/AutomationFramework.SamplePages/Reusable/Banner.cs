using OpenQA.Selenium;
using System.Collections.Generic;
using AutomationFramework.PageObjects;
using AutomationFramework.SamplePages.Pages;
using AutomationFramework.SamplePages.Interfaces;

namespace AutomationFramework.SamplePages.Reusable
{
    internal class Banner : WebPage, IBanner
    {
        #region WebElements

        protected IWebElement GitHubLogo => FindElementBy(By.XPath("//span[@aria-label='Homepage']"));
        protected IWebElement FeaturesLink => FindElementBy(By.XPath("//div[@class='HeaderMenu']//a[text()='Features']"));
        protected IWebElement BusinessLink => FindElementBy(By.XPath("//div[@class='HeaderMenu']//a[text()='Pricing']"));
        protected IWebElement ExploreLink => FindElementBy(By.XPath("//div[@class='HeaderMenu']//a[text()='Explore']"));
        protected IWebElement MarketplaceLink => FindElementBy(By.XPath("//div[@class='HeaderMenu']//a[text()='Marketplace']"));
        protected IWebElement PricingLink => FindElementBy(By.XPath("//div[@class='HeaderMenu']//a[text()='Pricing']"));
        protected IWebElement SearchTextBox => FindElementBy(By.Name("q"));

        #endregion

        #region Constructor

        public Banner()
        {
            WebElements.AddRange(
                new List<IWebElement>
                {
                    GitHubLogo, FeaturesLink, BusinessLink, ExploreLink,
                    MarketplaceLink, PricingLink, SearchTextBox
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
            SearchTextBox.Click();
            SearchTextBox.Clear();
            SearchTextBox.SendKeys(querryString + Keys.Return);

            return Factory.Get<SearchResultsPage>();
        }

        #endregion
    }
}
