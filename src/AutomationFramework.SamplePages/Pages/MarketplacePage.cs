using System.Linq;
using System.Collections.Generic;
using OpenQA.Selenium;
using AutomationFramework.PageObjects;
using AutomationFramework.SamplePages.Reusable;
using AutomationFramework.SamplePages.Interfaces;

namespace AutomationFramework.SamplePages.Pages
{
    public class MarketplacePage : WebPage, IMarketplace
    {
        #region PageSections

        private INavBar _banner;

        #endregion

        #region WebElements

        protected IWebElement SearchMarketPlaceTextbox => FindElementBy(By.Name("query"));
        protected IList<IWebElement> CategoriesList => FindElementsBy(By.ClassName("filter-item"));

        #endregion

        #region Initializers

        public MarketplacePage()
        {
            WebElements.Add(SearchMarketPlaceTextbox);
            WebElements.AddRange(CategoriesList);
        }

        public override void InitializePageSections()
        {
            _banner = new LoggedOutNavBar(Driver, Wait, Factory, WebElements);
        }

        #endregion

        #region Methods

        public IMarketplace SearchMarketPlace(string nameOrDescription)
        {
            SearchMarketPlaceTextbox.Click();
            SearchMarketPlaceTextbox.Clear();
            SearchMarketPlaceTextbox.SendKeys(nameOrDescription + Keys.Return);

            return Factory.Get<MarketplacePage>();
        }

        public IMarketplace ClickCategory(string nameOfCategory)
        {
            CategoriesList.SingleOrDefault(item => item.Text.Contains(nameOfCategory)).Click();

            return Factory.Get<MarketplacePage>();
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
