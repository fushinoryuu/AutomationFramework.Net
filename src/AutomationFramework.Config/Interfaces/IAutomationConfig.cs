using AutomationConfig.Enums;
using OperatingSystem = AutomationConfig.Enums.OperatingSystem;

namespace AutomationConfig.Interfaces
{
    public interface IAutomationConfig
    {
        Browser TargetBrowser { get; }
        OperatingSystem TargetOperatingSystem { get; }
        string HubLocation { get; }
        string BaseUrl { get; }
    }
}
