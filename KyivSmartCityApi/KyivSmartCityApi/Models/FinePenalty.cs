using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FinePenalty
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("car")]
        public Car Car { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("details")]
        public List<FineDetail> Details { get; set; }
        [JsonProperty("discount")]
        public string Discount { get; set; }
        [JsonProperty("has_pib")]
        public bool HasPib { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("payment_items")]
        public List<PenaltyItem> PaymentItems { get; set; }
        [JsonProperty("photos")]
        public List<string> Photos { get; set; }
        [JsonProperty("restrict_payment")]
        public bool IsRestrictPayment { get; set; }
        [JsonProperty("sum")]
        public long Sum { get; set; }
    }
}