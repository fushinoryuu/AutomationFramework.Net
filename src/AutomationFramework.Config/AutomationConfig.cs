using System.IO;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using AutomationFramework.Config.Enums;
using AutomationFramework.Config.Containers;
using AutomationFramework.Config.Interfaces;

namespace AutomationFramework.Config
{
    public class AutomationConfig : IAutomationConfig
    {
        public Browser TargetBrowser { get; set; }
        public OperatingSystem TargetOperatingSystem { get; set; }
        public IList<HubLocation> HubLocations { get; set; }
        public DriverLocation ActiveDriverLocation { get; set; }
        public IList<BaseUrl> BaseUrls { get; set; }
        public Environment ActiveEnvironment { get; set; }

        public static IAutomationConfig DeserializeConfig(string fileName)
        {
            var file = File.ReadAllText(fileName);

            return JsonConvert.DeserializeObject<AutomationConfig>(file);
        }

        public string GetBaseUrl(Environment environment)
        {
            return BaseUrls
                .Where(item => item.EnvironmentName.Equals(environment))
                .FirstOrDefault()
                .Url;
        }

        public string GetDriverLocation(DriverLocation location)
        {
            return HubLocations
                .Where(item => item.Location.Equals(location))
                .FirstOrDefault()
                .Url;
        }
    }
}
