using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FeedItem
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("icon")]
        public string Icon { get; set; }
        [JsonPropertyName("body")]
        public List<Body> Body { get; set; }
        public bool with_voting { get; set; }
        public object voted_for { get; set; }
        [JsonPropertyName("links")]
        public List<Links> Links { get; set; }
        [JsonPropertyName("feed_item")]
        public Feed Feed { get; set; }
    }
}