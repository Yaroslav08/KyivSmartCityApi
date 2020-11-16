using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Card
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("isSelected")]
        public bool IsSelected { get; set; }
        [JsonPropertyName("main")]
        public bool IsMain { get; set; }
        [JsonPropertyName("mask")]
        public string Mask { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("type")]
        public CardType Type { get; set; }
        [JsonPropertyName("discount")]
        public string Discount { get; set; }
        [JsonPropertyName("expired")]
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