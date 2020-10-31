using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class HourlyParkingFeedData
    {
        [JsonProperty("data")]
        public List<HourlyParkingFeedItem> Data { get; set; }
        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}