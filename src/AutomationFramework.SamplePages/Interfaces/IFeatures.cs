using AutomationFramework.PageObjects.Interfaces;

namespace AutomationFramework.SamplePages.Interfaces
{
    public interface IFeatures : IBanner, IWebPage
    {
        IFeatures ClickFeatureTile(string nameOfFeature);
    }
}
