using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FinePenalty
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("car")]
        public Car Car { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("details")]
        public List<FineDetail> Details { get; set; }
        [JsonPropertyName("discount")]
        public string Discount { get; set; }
        [JsonPropertyName("has_pib")]
        public bool HasPib { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("payment_items")]
        public List<PenaltyItem> PaymentItems { get; set; }
        [JsonPropertyName("photos")]
        public List<string> Photos { get; set; }
        [JsonPropertyName("restrict_payment")]
        public bool IsRestrictPayment { get; set; }
        [JsonPropertyName("sum")]
        public long Sum { get; set; }
    }
}