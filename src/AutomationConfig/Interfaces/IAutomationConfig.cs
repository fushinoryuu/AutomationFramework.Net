using AutomationConfig.Enums;
using OperatingSystem = AutomationConfig.Enums.OperatingSystem;

namespace AutomationConfig.Interfaces
{
    public interface IAutomationConfig
    {
        Browser TargetBrowser { get; set; }
        OperatingSystem TargetOperatingSystem { get; set; }
        string HubLocation { get; set; }
    }
}
