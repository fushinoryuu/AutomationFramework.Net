using AutomationFramework.Config.Containers;
using AutomationFramework.Config.Enums;
using AutomationFramework.Config.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AutomationFramework.Config
{
    public class AutomationConfig : IAutomationConfig
    {
        [JsonProperty("TargetBrowsers", ItemConverterType = typeof(StringEnumConverter))]
        public IList<Browser> TargetBrowsers { get; set; }

        [JsonProperty("TargetOperatingSystem"), JsonConverter(typeof(StringEnumConverter))]
        public OperatingSystem TargetOperatingSystem { get; set; }

        [JsonProperty("HubLocations")]
        public IList<HubLocation> HubLocations { get; set; }

        [JsonProperty("ActiveDriverLocation"), JsonConverter(typeof(StringEnumConverter))]
        public DriverLocation ActiveDriverLocation { get; set; }

        [JsonProperty("BaseUrls")]
        public IList<BaseUrl> BaseUrls { get; set; }

        [JsonProperty("ActiveEnvironment"), JsonConverter(typeof(StringEnumConverter))]
        public Environment ActiveEnvironment { get; set; }

        public static IAutomationConfig DeserializeConfig(string fileName)
        {
            var file = File.ReadAllText(fileName);

            return JsonConvert.DeserializeObject<AutomationConfig>(file);
        }

        public string GetBaseUrl(Environment environment)
        {
            return BaseUrls
                .FirstOrDefault(item => item.EnvironmentName.Equals(environment))
                ?.Url;
        }

        public string GetDriverLocation(DriverLocation location)
        {
            return HubLocations
                .FirstOrDefault(item => item.Location.Equals(location))
                ?.Url;
        }
    }
}
