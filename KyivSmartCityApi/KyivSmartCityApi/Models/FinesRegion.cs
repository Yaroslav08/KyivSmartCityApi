using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FinesRegion
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string RegionName { get; set; }
        [JsonPropertyName("short_name")]
        public string ShortName { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}