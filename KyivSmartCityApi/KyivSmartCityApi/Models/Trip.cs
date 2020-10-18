using KyivSmartCityApi.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Trip
    {
        [JsonProperty("line")]
        public string Line { get; set; }
        [JsonProperty("stop_name")]
        public string StopName { get; set; }
        [JsonProperty("route_name")]
        public string RouteName { get; set; }
        [JsonProperty("transport_type")]
        public string TransportType { get; set; }
        [JsonProperty("issued_at")]
        [JsonConverter(typeof(UtcDateTimeConverter))]
        public DateTime CreatedAt { get; set; }
    }
}