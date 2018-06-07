using OpenQA.Selenium;
using AutomationFramework.PageObjects;
using AutomationFramework.SamplePages.Reusable;
using AutomationFramework.SamplePages.Interfaces;

namespace AutomationFramework.SamplePages.Pages
{
    public class ExplorePage : WebPage, IExplore
    {
        #region PageSections

        private INavBar _banner;

        #endregion

        #region WebElements

        protected const string TabsLocator = "/explore?trending=";
        protected IWebElement RepositoriesTab => FindElementBy(By.CssSelector($"a[href*='{TabsLocator}repositories#trending']"));
        protected IWebElement DevelopersTab => FindElementBy(By.CssSelector($"a[href*='{TabsLocator}developers#trending']"));

        #endregion

        #region Initializers

        public ExplorePage()
        {
            WebElements.Add(RepositoriesTab);
            WebElements.Add(DevelopersTab);
        }

        public override void InitializePageSections()
        {
            _banner = new LoggedOutNavBar(Driver, Wait, Factory, WebElements);
        }

        #endregion

        #region Methods

        public IExplore ClickTrendingRepositoriesTab()
        {
            RepositoriesTab.Click();

            return Factory.Get<ExplorePage>();
        }

        public IExplore ClickTrendingDevelopersTab()
        {
            DevelopersTab.Click();

            return Factory.Get<ExplorePage>();
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
