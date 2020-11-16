using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class ZonePrice
    {
        [JsonPropertyName("first_hour")]
        public int FirstHour { get; set; }
        [JsonPropertyName("30m")]
        public int ThirtyMinutes { get; set; }
    }
}