using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class QrCodes
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }
        [JsonPropertyName("codes")]
        public List<QrCode> Codes { get; set; }
    }
}