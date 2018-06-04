using OpenQA.Selenium;
using AutomationFramework.PageObjects;
using AutomationFramework.SamplePages.Interfaces;
using AutomationFramework.SamplePages.Pages;

namespace AutomationFramework.SamplePages.Reusable
{
    internal class Banner : WebPage, IBanner
    {
        protected IWebElement GitHubLogo => FindElementBy(By.XPath("//span[@aria-label='Homepage']"));

        public IBusiness ClickBusinessLink()
        {
            throw new System.NotImplementedException();
        }

        public IExplore ClickExploreLink()
        {
            throw new System.NotImplementedException();
        }

        public IFeatures ClickFeaturesLink()
        {
            throw new System.NotImplementedException();
        }

        public IHome ClickGitHubLogo()
        {
            GitHubLogo.Click();

            return Factory.Get<HomePage>();
        }

        public IMarketplace ClickMarketplaceLink()
        {
            throw new System.NotImplementedException();
        }

        public IPricing ClickPricingLink()
        {
            throw new System.NotImplementedException();
        }

        public ISearchResults SearchGitHub(string querryString)
        {
            throw new System.NotImplementedException();
        }

        public override void WaitForPageToLoad()
        {
            throw new System.NotImplementedException();
        }
    }
}
