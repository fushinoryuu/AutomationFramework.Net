using OpenQA.Selenium;
using AutomationFramework.PageObjects;
using AutomationFramework.SamplePages.Reusable;
using AutomationFramework.SamplePages.Interfaces;

namespace AutomationFramework.SamplePages.Pages
{
    public class PricingPage : WebPage, IPricing
    {
        #region PageSections

        private INavBar _banner;

        #endregion

        #region WebElements

        protected IWebElement ContactUsLink => FindElementBy(By.ClassName("plans-card-business-contact"));

        #endregion

        #region Initializers

        public PricingPage()
        {
            WebElements.Add(ContactUsLink);
        }

        public override void InitializePageSections()
        {
            _banner = new LoggedOutNavBar(Driver, Wait, Factory, WebElements);
        }

        #endregion

        #region Methods

        public IContactUs ClickContactUsLink()
        {
            ContactUsLink.Click();

            return Factory.Get<ContactUsPage>();
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
