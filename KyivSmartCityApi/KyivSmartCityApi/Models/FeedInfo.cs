using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FeedInfo
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("body")]
        public List<Body> Body { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("icon")]
        public string Icon { get; set; }
        [JsonPropertyName("links")]
        public List<Link> Links { get; set; }
        [JsonPropertyName("title")]
        private string Title { get; set; }
        [JsonPropertyName("voted_for")]
        private int VotedFor { get; set; }
        [JsonPropertyName("with_voting")]
        private bool WithVoting { get; set; }
    }
}