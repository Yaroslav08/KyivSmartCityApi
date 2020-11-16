using KyivSmartCityApi.Settings;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace KyivSmartCityApi.Models
{
    public class Feed
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("type")]
        public int Type { get; set; }
        [JsonPropertyName("icon")]
        public string Icon { get; set; }
        [JsonPropertyName("sub_icon")]
        public string SubIcon { get; set; }
        [JsonPropertyName("read")]
        public bool Read { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("value_sum")]
        public string ValueSum { get; set; }
        [JsonPropertyName("value_text")]
        public string ValueText { get; set; }
        [JsonPropertyName("value_img")]
        public string ValueImg { get; set; }
        [JsonPropertyName("created_at")]
        [JsonConverter(typeof(UtcDateTimeConverter))]
        public DateTime CreatedAt { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\tTitle: {Title}\tDescription: {Description}\tDate: {CreatedAt.ToShortTimeString()} - {CreatedAt.ToShortDateString()}";
        }
    }
}