using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Link
    {
        [JsonPropertyName("icon")]
        private string Icon { get; set; }
        [JsonPropertyName("text")]
        private string Text { get; set; }
        [JsonPropertyName("url")]
        private string Url { get; set; }
    }
}