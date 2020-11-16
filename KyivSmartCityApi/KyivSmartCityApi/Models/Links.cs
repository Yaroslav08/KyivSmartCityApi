using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Links
    {
        [JsonPropertyName("next")]
        public string Next { get; set; }
        [JsonPropertyName("previous")]
        public string Previous { get; set; }
    }
}