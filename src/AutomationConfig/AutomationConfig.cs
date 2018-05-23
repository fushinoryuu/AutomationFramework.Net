using System.IO;
using Newtonsoft.Json;
using AutomationConfig.Enums;
using AutomationConfig.Interfaces;
using OperatingSystem = AutomationConfig.Enums.OperatingSystem;

namespace AutomationConfig
{
    public class AutomationConfig : IAutomationConfig
    {
        public Browser TargetBrowser { get; set; }
        public OperatingSystem TargetOperatingSystem { get; set; }
        public string HubLocation { get; set; }

        public static IAutomationConfig DeserializeConfig(string fileName)
        {
            var file = File.ReadAllText(fileName);

            return JsonConvert.DeserializeObject<AutomationConfig>(file);
        }
    }
}
