using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class HourlyParking
    {
        [JsonPropertyName("active_session")]
        public ActiveSession ActiveSession { get; set; }
        [JsonPropertyName("cards")]
        public List<Card> Cards { get; set; }
        [JsonPropertyName("cars")]
        public List<Car> Cars { get; set; }
        [JsonPropertyName("debt")]
        public int Debt { get; set; }
        [JsonPropertyName("faq_category_id")]
        public int FaqCategoryId { get; set; }
        [JsonPropertyName("free_message")]
        public string FreeMessage { get; set; }
        [JsonPropertyName("payment_error")]
        public bool PaymentError { get; set; }
        [JsonPropertyName("payment_message")]
        public string PaymentMessage { get; set; }
        [JsonPropertyName("places")]
        public Places Places { get; set; }
        [JsonPropertyName("prices")]
        public Dictionary<string, ZonePrice> Prices { get; set; }
    }
}