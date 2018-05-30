using AutomationFramework.Config.Enums;

namespace AutomationFramework.Config.Interfaces
{
    public interface IAutomationConfig
    {
        Browser TargetBrowser { get; }
        OperatingSystem TargetOperatingSystem { get; }
        string HubLocation { get; }
        string BaseUrl { get; }
        DriverLocation ActiveDriverLocation { get; }
    }
}
