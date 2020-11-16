using KyivSmartCityApi.Settings;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Trip
    {
        [JsonPropertyName("line")]
        public string Line { get; set; }
        [JsonPropertyName("stop_name")]
        public string StopName { get; set; }
        [JsonPropertyName("route_name")]
        public string RouteName { get; set; }
        [JsonPropertyName("transport_type")]
        public string TransportType { get; set; }
        [JsonPropertyName("issued_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime CreatedAt { get; set; }
    }
}