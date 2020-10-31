using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FeedFine
    {
        [JsonProperty("car")]
        public Car Car { get; set; }
        [JsonProperty("feed_item")]
        public Feed Feed { get; set; }
        [JsonProperty("receipt")]
        public string Receipt { get; set; }
    }
}