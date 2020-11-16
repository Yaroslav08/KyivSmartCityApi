using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Actions
    {
        [JsonPropertyName("replenishment")]
        public bool Replenishment { get; set; }
        [JsonPropertyName("buy_monthly")]
        public bool BuyMonthly { get; set; }
        [JsonPropertyName("rename")]
        public bool Rename { get; set; }
        [JsonPropertyName("block")]
        public bool Block { get; set; }
        [JsonPropertyName("replace")]
        public bool Replace { get; set; }
    }
}