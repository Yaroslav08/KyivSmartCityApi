using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class PendingPenalty
    {
        [JsonProperty("id")]
        private string Id;
        [JsonProperty("car")]
        private Car Car;
        [JsonProperty("description")]
        private string Description;
        [JsonProperty("discount")]
        private string Discount;
        [JsonProperty("name")]
        private string Name;
        [JsonProperty("receipt")]
        private string Receipt;
        [JsonProperty("sum")]
        private long Sum;
        [JsonProperty("type")]
        private string Type;
    }
}