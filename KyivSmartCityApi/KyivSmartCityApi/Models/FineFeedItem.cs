using KyivSmartCityApi.Settings;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FineFeedItem
    {
        [JsonPropertyName("title")]
        private string Title { get; set; }
        [JsonPropertyName("description")]
        private string Description { get; set; }
        [JsonPropertyName("valueSum")]
        private int ValueSum { get; set; }
        [JsonPropertyName("valueText")]
        private string ValueText { get; set; }
        [JsonPropertyName("createdAt")]
        [JsonConverter(typeof(UtcDateTimeConverter))]
        private DateTime CreatedAt { get; set; }
        [JsonPropertyName("icon")]
        private string Icon { get; set; }
        [JsonPropertyName("subIcon")]
        private string SubIcon { get; set; }
    }
}