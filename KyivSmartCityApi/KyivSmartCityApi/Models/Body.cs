using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Body
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}