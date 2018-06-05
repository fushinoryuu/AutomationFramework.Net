using System;
using AutomationFramework.PageObjects;
using AutomationFramework.SamplePages.Interfaces;

namespace AutomationFramework.SamplePages.Pages
{
    public class MarketplacePage : WebPage, IMarketplace
    {
        public IBusiness ClickBusinessLink()
        {
            throw new NotImplementedException();
        }

        public IMarketplace ClickCategory(string nameOfCategory)
        {
            throw new NotImplementedException();
        }

        public IExplore ClickExploreLink()
        {
            throw new NotImplementedException();
        }

        public IFeatures ClickFeaturesLink()
        {
            throw new NotImplementedException();
        }

        public IHome ClickGitHubLogo()
        {
            throw new NotImplementedException();
        }

        public IMarketplace ClickMarketplaceLink()
        {
            throw new NotImplementedException();
        }

        public IPricing ClickPricingLink()
        {
            throw new NotImplementedException();
        }

        public ISearchResults SearchGitHub(string querryString)
        {
            throw new NotImplementedException();
        }

        public IMarketplace SearchMarketPlace(string nameOrDescription)
        {
            throw new NotImplementedException();
        }
    }
}
