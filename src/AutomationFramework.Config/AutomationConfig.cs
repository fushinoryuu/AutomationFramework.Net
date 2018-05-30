using System.IO;
using Newtonsoft.Json;
using AutomationFramework.Config.Enums;
using AutomationFramework.Config.Interfaces;

namespace AutomationFramework.Config
{
    public class AutomationConfig : IAutomationConfig
    {
        public Browser TargetBrowser { get; set; }
        public OperatingSystem TargetOperatingSystem { get; set; }
        public string HubLocation { get; set; }
        public string BaseUrl { get; set; }
        public DriverLocation ActiveDriverLocation { get; set; }

        public static IAutomationConfig DeserializeConfig(string fileName)
        {
            var file = File.ReadAllText(fileName);

            return JsonConvert.DeserializeObject<AutomationConfig>(file);
        }
    }
}
