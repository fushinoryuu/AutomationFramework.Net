using System.Linq;
using System.Collections.Generic;
using OpenQA.Selenium;
using AutomationFramework.PageObjects;
using AutomationFramework.SamplePages.Reusable;
using AutomationFramework.SamplePages.Interfaces;

namespace AutomationFramework.SamplePages.Pages
{
    public class FeaturesPage : WebPage, IFeatures
    {
        #region PageSections

        private INavBar _banner;

        #endregion

        #region WebElements

        protected IList<IWebElement> TileLists => FindElementsBy(By.XPath("//div[@class='container-xl']//a[@class='no-underline']"));

        #endregion

        #region Initializers

        public FeaturesPage()
        {
            WebElements.AddRange(TileLists);
        }

        public override void InitializePageSections()
        {
            _banner = new LoggedOutNavBar(Driver, Wait, Factory, WebElements);
        }

        #endregion

        #region Methods

        public IFeatures ClickFeatureTile(string nameOfFeature)
        {
            TileLists.FirstOrDefault(item => item.Text.Contains(nameOfFeature)).Click();

            return Factory.Get<FeaturesPage>();
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
