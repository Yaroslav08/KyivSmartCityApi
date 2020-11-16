using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Headline
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("weather")]
        public Weather Weather { get; set; }
    }
}