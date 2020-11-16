using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class BankCard
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("mask")]
        public string Mask { get; set; }
        [JsonPropertyName("main")]
        public bool Main { get; set; }
        [JsonPropertyName("expired")]
        public bool Expired { get; set; }
    }
}