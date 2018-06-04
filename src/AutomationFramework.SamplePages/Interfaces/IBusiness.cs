using AutomationFramework.PageObjects.Interfaces;

namespace AutomationFramework.SamplePages.Interfaces
{
    public interface IBusiness : IBanner, IWebPage
    {
        IBusiness ClickTeamsUseGitHubButton();
    }
}
