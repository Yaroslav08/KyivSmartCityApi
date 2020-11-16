using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class AddressPart
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}