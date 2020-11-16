using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace KyivSmartCityApi.Models
{
    public class ZonePrices
    {
        [JsonPropertyName("prices")]
        public Prices Prices { get; set; }
    }
    public class Prices
    {
        [JsonPropertyName("copy")]
        public int Copy { get; set; }
        [JsonPropertyName("zone_1")]
        public int Zone1 { get; set; }
        [JsonPropertyName("zone_2")]
        public int Zone2 { get; set; }
        [JsonPropertyName("zone_3")]
        public int Zone3 { get; set; }
    }

}