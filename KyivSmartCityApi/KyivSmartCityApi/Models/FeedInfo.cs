using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FeedInfo
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("body")]
        public List<Body> Body { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("links")]
        public List<Link> Links { get; set; }
        [JsonProperty("title")]
        private string Title { get; set; }
        [JsonProperty("voted_for")]
        private int VotedFor { get; set; }
        [JsonProperty("with_voting")]
        private bool WithVoting { get; set; }
    }
}