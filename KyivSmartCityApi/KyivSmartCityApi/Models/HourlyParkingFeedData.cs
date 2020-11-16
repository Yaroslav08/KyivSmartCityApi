using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class HourlyParkingFeedData
    {
        [JsonPropertyName("data")]
        public List<HourlyParkingFeedItem> Data { get; set; }
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }
}