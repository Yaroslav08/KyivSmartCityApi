using KyivSmartCityApi.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class QrCode
    {
        [JsonProperty("id")]
        private long Id { get; set; }
        [JsonProperty("code")]
        private string Code { get; set; }
        [JsonProperty("expireAt")]
        [JsonConverter(typeof(UtcDateTimeConverter))]
        private DateTime ExpireAt { get; set; }
        [JsonProperty("shared")]
        private bool IsShared { get; set; }
        [JsonProperty("used")]
        private bool IsUsed { get; set; }
    }
}