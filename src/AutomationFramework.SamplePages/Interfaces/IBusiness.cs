using AutomationFramework.PageObjects.Interfaces;

namespace AutomationFramework.SamplePages.Interfaces
{
    public interface IBusiness : INavBar, IWebPage
    {
        IBusiness ClickTeamsUseGitHubButton();
    }
}
