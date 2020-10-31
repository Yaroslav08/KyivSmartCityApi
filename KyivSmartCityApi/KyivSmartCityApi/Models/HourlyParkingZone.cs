using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class HourlyParkingZone
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("number")]
        public string Number { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("zone")]
        public int Zone { get; set; }
        [JsonProperty("isClosest")]
        public bool IsClosest { get; set; }
        [JsonProperty("isSelected")]
        public bool IsSelected { get; set; }
    }
}