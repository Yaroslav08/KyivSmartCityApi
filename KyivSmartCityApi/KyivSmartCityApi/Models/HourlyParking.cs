using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class HourlyParking
    {
        [JsonProperty("active_session")]
        public ActiveSession ActiveSession { get; set; }
        [JsonProperty("cards")]
        public List<Card> Cards { get; set; }
        [JsonProperty("cars")]
        public List<Car> Cars { get; set; }
        [JsonProperty("debt")]
        public int Debt { get; set; }
        [JsonProperty("faq_category_id")]
        public int FaqCategoryId { get; set; }
        [JsonProperty("free_message")]
        public string FreeMessage { get; set; }
        [JsonProperty("payment_error")]
        public bool PaymentError { get; set; }
        [JsonProperty("payment_message")]
        public string PaymentMessage { get; set; }
        [JsonProperty("places")]
        public Places Places { get; set; }
        [JsonProperty("prices")]
        public Dictionary<string, ZonePrice> Prices { get; set; }
    }
}