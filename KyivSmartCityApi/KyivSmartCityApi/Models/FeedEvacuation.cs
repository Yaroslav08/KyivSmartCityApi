using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FeedEvacuation
    {
        [JsonPropertyName("car")]
        public Car Car { get; set; }
        [JsonPropertyName("completed")]
        public bool IsComplated { get; set; }
        [JsonPropertyName("feed_item")]
        public Feed Feed { get; set; }
        [JsonPropertyName("receipt")]
        public string Receipt { get; set; }
    }
}
