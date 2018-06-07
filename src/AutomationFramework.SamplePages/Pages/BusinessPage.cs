﻿using System;
using AutomationFramework.PageObjects;
using AutomationFramework.SamplePages.Reusable;
using AutomationFramework.SamplePages.Interfaces;

namespace AutomationFramework.SamplePages.Pages
{
    public class BusinessPage : WebPage, IBusiness
    {
        private INavBar _banner;

        public override void InitializePageSections()
        {
            _banner = new LoggedOutNavBar(Driver, Wait, Factory, WebElements);
        }

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
    }
}
