using System;
using AutomationFramework.PageObjects;
using AutomationFramework.SamplePages.Interfaces;

namespace AutomationFramework.SamplePages.Pages
{
    public class FeaturesPage : WebPage, IFeatures
    {
        public IBusiness ClickBusinessLink()
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

        public IFeatures ClickFeatureTile(string nameOfFeature)
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

        public override void InitializePageSections()
        {
            throw new NotImplementedException();
        }

        public ISearchResults SearchGitHub(string querryString)
        {
            throw new NotImplementedException();
        }
    }
}
