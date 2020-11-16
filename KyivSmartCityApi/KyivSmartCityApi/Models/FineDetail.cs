using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FineDetail
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}