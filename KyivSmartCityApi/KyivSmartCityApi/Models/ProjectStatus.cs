using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class ProjectStatus
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}