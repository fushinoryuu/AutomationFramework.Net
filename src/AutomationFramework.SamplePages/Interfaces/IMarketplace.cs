using AutomationFramework.PageObjects.Interfaces;

namespace AutomationFramework.SamplePages.Interfaces
{
    public interface IMarketplace : IBanner, IWebPage
    {
        IMarketplace SearchMarketPlace(string nameOrDescription);
        IMarketplace ClickCategory(string nameOfCategory);
    }
}
