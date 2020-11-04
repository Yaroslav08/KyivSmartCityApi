using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class KyivSmartCash
    {
        [JsonProperty("available")]
        public bool Available { get; set; }
        [JsonProperty("cashback")]
        public string Cashback { get; set; }
    }
}