using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class CreateSmartCardModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("number")]
        public string Number { get; set; }
        [JsonPropertyName("pin")]
        public string Pin { get; set; }
    }
}