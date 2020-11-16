using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FinesFeedData
    {

        [JsonPropertyName("data")]
        public List<FineFeedItem> Data { get; set; }
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }
}