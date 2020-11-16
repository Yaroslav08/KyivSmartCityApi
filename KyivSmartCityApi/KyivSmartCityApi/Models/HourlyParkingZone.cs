using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class HourlyParkingZone
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("number")]
        public string Number { get; set; }
        [JsonPropertyName("address")]
        public string Address { get; set; }
        [JsonPropertyName("zone")]
        public int Zone { get; set; }
        [JsonPropertyName("isClosest")]
        public bool IsClosest { get; set; }
        [JsonPropertyName("isSelected")]
        public bool IsSelected { get; set; }
    }
}