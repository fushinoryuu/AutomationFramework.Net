namespace AutomationFramework.SamplePages.Interfaces
{
    public interface IBanner
    {
        IHome ClickGitHubLogo();
        IFeatures ClickFeaturesLink();
        IBusiness ClickBusinessLink();
        IExplore ClickExploreLink();
        IMarketplace ClickMarketplaceLink();
        IPricing ClickPricingLink();
        ISearchResults SearchGitHub(string querryString);
    }
}
