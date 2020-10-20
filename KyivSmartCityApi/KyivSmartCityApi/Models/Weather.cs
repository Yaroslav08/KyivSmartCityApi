using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Weather
    {
        [JsonProperty("temp")]
        public int Temp { get; set; }
        [JsonProperty("condition")]
        public int Condition { get; set; }
    }
}