using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FinePayment
    {
        [JsonPropertyName("cards")]
        public List<Card> Cards { get; set; }
        [JsonPropertyName("fee_percent")]
        public double FeePercent { get; set; }
        [JsonPropertyName("penalty")]
        public FinePenalty Penalty { get; set; }
    }
}