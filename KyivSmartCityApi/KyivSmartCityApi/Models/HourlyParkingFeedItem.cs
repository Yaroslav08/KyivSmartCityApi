using KyivSmartCityApi.Settings;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class HourlyParkingFeedItem
    {
        [JsonPropertyName("id")]
        public string Id { get;set; }
        [JsonPropertyName("created_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime CreatedAt { get;set; }
        [JsonPropertyName("title")]
        public string Title { get;set; }
        [JsonPropertyName("description")]
        public string Description { get;set; }
        [JsonPropertyName("icon")]
        public string Icon { get;set; }
        [JsonPropertyName("read")]
        public bool IsRead { get;set; }
        [JsonPropertyName("type")]
        public int Type { get;set; }
        [JsonPropertyName("value_img")]
        public string ValueImg { get;set; }
        [JsonPropertyName("value_sum")]
        public int ValueSum { get;set; }
        [JsonPropertyName("value_text")]
        public string ValueText { get;set; }
    }
}