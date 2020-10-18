using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Actions
    {
        [JsonProperty("replenishment")]
        public bool Replenishment { get; set; }
        [JsonProperty("buy_monthly")]
        public bool BuyMonthly { get; set; }
        [JsonProperty("rename")]
        public bool Rename { get; set; }
        [JsonProperty("block")]
        public bool Block { get; set; }
        [JsonProperty("replace")]
        public bool Replace { get; set; }
    }
}