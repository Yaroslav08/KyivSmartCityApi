using KyivSmartCityApi.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FineFeedItem
    {
        [JsonProperty("title")]
        private string Title { get; set; }
        [JsonProperty("description")]
        private string Description { get; set; }
        [JsonProperty("valueSum")]
        private int ValueSum { get; set; }
        [JsonProperty("valueText")]
        private string ValueText { get; set; }
        [JsonProperty("createdAt")]
        [JsonConverter(typeof(UtcDateTimeConverter))]
        private DateTime CreatedAt { get; set; }
        [JsonProperty("icon")]
        private string Icon { get; set; }
        [JsonProperty("subIcon")]
        private string SubIcon { get; set; }
    }
}