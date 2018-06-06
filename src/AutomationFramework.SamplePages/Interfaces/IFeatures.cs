using AutomationFramework.PageObjects.Interfaces;

namespace AutomationFramework.SamplePages.Interfaces
{
    public interface IFeatures : INavBar, IWebPage
    {
        IFeatures ClickFeatureTile(string nameOfFeature);
    }
}
