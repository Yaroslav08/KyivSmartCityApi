using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class HourlyParkingFeed
    {
        [JsonPropertyName("feed")]
        public HourlyParkingFeedData Feed { get; set; }
    }
}