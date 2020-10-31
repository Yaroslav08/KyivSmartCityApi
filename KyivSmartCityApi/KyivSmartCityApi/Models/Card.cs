using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Card
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("isSelected")]
        public bool IsSelected { get; set; }
        [JsonProperty("main")]
        public bool IsMain { get; set; }
        [JsonProperty("mask")]
        public string Mask { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        public CardType Type { get; set; }
        [JsonProperty("discount")]
        public string Discount { get; set; }
        [JsonProperty("expired")]
        public bool IsExpired { get; set; }
    }
    public enum CardType
    {
        CARD,
        CONNECT_MASTERPASS,
        ADD_CARD,
        GERZ,
        INFO,
        KYIV_SMART_CASH
    }
}