using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class BankCard
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("mask")]
        public string Mask { get; set; }
        [JsonProperty("main")]
        public bool Main { get; set; }
        [JsonProperty("expired")]
        public bool Expired { get; set; }
    }
}