using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace KyivSmartCityApi.Models
{
    public class Account
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("icon")]
        public string Icon { get; set; }
        [JsonPropertyName("connected")]
        public bool Connected { get; set; }
        [JsonPropertyName("connect_link")]
        public string ConnectLink { get; set; }
    }
}