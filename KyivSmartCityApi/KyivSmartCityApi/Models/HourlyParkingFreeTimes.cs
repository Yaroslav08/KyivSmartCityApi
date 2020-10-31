using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class HourlyParkingFreeTimes
    {
        [JsonProperty("hours")]
        public List<int> Hours { get; set; }
    }
}