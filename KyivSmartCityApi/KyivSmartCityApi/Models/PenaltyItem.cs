using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class PenaltyItem
    {
        [JsonProperty("discount_sum")]
        public int DiscountSum { get; set; }
        [JsonProperty("sub_title")]
        public string SubTitle { get; set; }
        [JsonProperty("sum")]
        public int Sum { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}