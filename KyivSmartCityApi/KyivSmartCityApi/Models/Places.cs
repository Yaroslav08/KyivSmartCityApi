using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Places
    {
        [JsonProperty("closest")]
        public HourlyParkingZone Closest { get; set; }
        [JsonProperty("zones")]
        public Dictionary<string, List<HourlyParkingZone>> Zones { get; set; }

    }
}