using AutomationFramework.PageObjects.Interfaces;

namespace AutomationFramework.SamplePages.Interfaces
{
    public interface IExplore : IBanner, IWebPage
    {
        IExplore ClickTrendingRepositoriesTab();
        IExplore ClickTrendingDevelopersTab();
    }
}
