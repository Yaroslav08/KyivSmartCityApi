using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class HourlyParkingFreeTimes
    {
        [JsonPropertyName("hours")]
        public List<int> Hours { get; set; }
    }
}