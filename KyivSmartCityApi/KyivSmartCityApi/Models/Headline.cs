using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Headline
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("weather")]
        public Weather Weather { get; set; }
    }
}