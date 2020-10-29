using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class ZonePrices
    {
        [JsonProperty("prices")]
        public Prices Prices { get; set; }
    }
    public class Prices
    {
        [JsonProperty("copy")]
        public int Copy { get; set; }
        [JsonProperty("zone_1")]
        public int Zone1 { get; set; }
        [JsonProperty("zone_2")]
        public int Zone2 { get; set; }
        [JsonProperty("zone_3")]
        public int Zone3 { get; set; }
    }

}