using AutomationFramework.PageObjects.Interfaces;

namespace AutomationFramework.SamplePages.Interfaces
{
    public interface IExplore : INavBar, IWebPage
    {
        IExplore ClickTrendingRepositoriesTab();
        IExplore ClickTrendingDevelopersTab();
    }
}
