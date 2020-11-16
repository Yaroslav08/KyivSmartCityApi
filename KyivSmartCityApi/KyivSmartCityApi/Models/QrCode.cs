using KyivSmartCityApi.Settings;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class QrCode
    {
        [JsonPropertyName("id")]
        private long Id { get; set; }
        [JsonPropertyName("code")]
        private string Code { get; set; }
        [JsonPropertyName("expireAt")]
        [JsonConverter(typeof(DateTimeConverter))]
        private DateTime ExpireAt { get; set; }
        [JsonPropertyName("shared")]
        private bool IsShared { get; set; }
        [JsonPropertyName("used")]
        private bool IsUsed { get; set; }
    }
}