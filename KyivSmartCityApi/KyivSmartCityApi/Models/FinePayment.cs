using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FinePayment
    {
        [JsonProperty("cards")]
        public List<Card> Cards { get; set; }
        [JsonProperty("fee_percent")]
        public double FeePercent { get; set; }
        [JsonProperty("penalty")]
        public FinePenalty Penalty { get; set; }
    }
}