using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class PendingPenalty
    {
        [JsonPropertyName("id")]
        private string Id;
        [JsonPropertyName("car")]
        private Car Car;
        [JsonPropertyName("description")]
        private string Description;
        [JsonPropertyName("discount")]
        private string Discount;
        [JsonPropertyName("name")]
        private string Name;
        [JsonPropertyName("receipt")]
        private string Receipt;
        [JsonPropertyName("sum")]
        private long Sum;
        [JsonPropertyName("type")]
        private string Type;
    }
}