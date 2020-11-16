using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class ExpiringQRs
    {
        [JsonPropertyName("feed_item")]
        public Feed Feed { get; set; }
        [JsonPropertyName("qrs")]
        public List<QrCode> Qrs { get; set; }
    }
}