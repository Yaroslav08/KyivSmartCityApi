using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Places
    {
        [JsonPropertyName("closest")]
        public HourlyParkingZone Closest { get; set; }
        [JsonPropertyName("zones")]
        public Dictionary<string, List<HourlyParkingZone>> Zones { get; set; }

    }
}