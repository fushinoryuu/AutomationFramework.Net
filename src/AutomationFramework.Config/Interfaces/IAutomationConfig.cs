using System.Collections.Generic;
using AutomationFramework.Config.Enums;
using AutomationFramework.Config.Containers;

namespace AutomationFramework.Config.Interfaces
{
    public interface IAutomationConfig
    {
        Browser TargetBrowser { get; }
        OperatingSystem TargetOperatingSystem { get; }
        IList<HubLocation> HubLocations { get; }
        IList<BaseUrl> BaseUrls { get; }
        DriverLocation ActiveDriverLocation { get; }
        Environment ActiveEnvironment { get; }

        string GetBaseUrl(Environment environment);
        string GetDriverLocation(DriverLocation location);
    }
}
