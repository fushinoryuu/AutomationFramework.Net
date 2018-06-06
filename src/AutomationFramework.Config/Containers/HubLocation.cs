using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using AutomationFramework.Config.Enums;

namespace AutomationFramework.Config.Containers
{
    public class HubLocation
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public DriverLocation Location { get; set; }

        public string Url { get; set; }
    }
}
