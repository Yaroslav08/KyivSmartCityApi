using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FeedItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("body")]
        public List<Body> Body { get; set; }
        public bool with_voting { get; set; }
        public object voted_for { get; set; }
        [JsonProperty("links")]
        public List<Links> Links { get; set; }
        [JsonProperty("feed_item")]
        public Feed Feed { get; set; }
    }
}