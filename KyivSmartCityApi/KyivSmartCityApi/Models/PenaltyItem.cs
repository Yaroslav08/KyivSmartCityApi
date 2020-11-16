using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class PenaltyItem
    {
        [JsonPropertyName("discount_sum")]
        public int DiscountSum { get; set; }
        [JsonPropertyName("sub_title")]
        public string SubTitle { get; set; }
        [JsonPropertyName("sum")]
        public int Sum { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}