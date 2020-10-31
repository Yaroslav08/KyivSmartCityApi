using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FinesFeedData
    {

        [JsonProperty("data")]
        public List<FineFeedItem> Data { get; set; }
        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}