using System;
using OpenQA.Selenium;
using AutomationFramework.PageObjects;
using AutomationFramework.SamplePages.Reusable;
using AutomationFramework.SamplePages.Interfaces;

namespace AutomationFramework.SamplePages.Pages
{
    public class BusinessPage : WebPage, IBusiness
    {
        #region PageSections

        private INavBar _banner;

        #endregion

        #region WebElements

        protected IWebElement TeamsUsGitHubButton => FindElementBy(By.CssSelector("a[href*='/business/customers']"));

        #endregion

        #region Initializers

        public BusinessPage()
        {
            WebElements.Add(TeamsUsGitHubButton);
        }

        public override void InitializePageSections()
        {
            _banner = new LoggedOutNavBar(Driver, Wait, Factory, WebElements);
        }

        #endregion

        #region Methods

        public IBusiness ClickTeamsUseGitHubButton()
        {
            throw new NotImplementedException();
        }

        public IBusiness ClickBusinessLink() => _banner.ClickBusinessLink();

        public IExplore ClickExploreLink() => _banner.ClickExploreLink();

        public IFeatures ClickFeaturesLink() => _banner.ClickFeaturesLink();

        public IHome ClickGitHubLogo() => _banner.ClickGitHubLogo();

        public IMarketplace ClickMarketplaceLink() => _banner.ClickMarketplaceLink();

        public IPricing ClickPricingLink() => _banner.ClickPricingLink();

        public ISearchResults SearchGitHub(string querryString) => _banner.SearchGitHub(querryString);

        #endregion
    }
}
