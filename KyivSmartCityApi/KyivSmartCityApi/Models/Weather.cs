using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Weather
    {
        [JsonPropertyName("temp")]
        public int Temp { get; set; }
        [JsonPropertyName("condition")]
        public int Condition { get; set; }
    }
}