using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class ZonePrice
    {
        [JsonProperty("first_hour")]
        public int FirstHour { get; set; }
        [JsonProperty("30m")]
        public int ThirtyMinutes { get; set; }
    }
}