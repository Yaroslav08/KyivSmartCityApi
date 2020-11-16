using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class KyivSmartCash
    {
        [JsonPropertyName("available")]
        public bool Available { get; set; }
        [JsonPropertyName("cashback")]
        public string Cashback { get; set; }
    }
}