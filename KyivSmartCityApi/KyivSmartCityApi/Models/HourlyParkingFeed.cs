using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class HourlyParkingFeed
    {
        [JsonProperty("feed")]
        public HourlyParkingFeedData Feed { get; set; }
    }
}