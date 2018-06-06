using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using AutomationFramework.Config.Enums;

namespace AutomationFramework.Config.Containers
{
    public class BaseUrl
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public Environment EnvironmentName { get; set; }

        public string Url { get; set; }
    }
}
