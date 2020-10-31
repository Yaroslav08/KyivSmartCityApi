using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FineOrderReceipt
    {
        [JsonProperty("order_id")]
        public long OrderId { get; set; }
        [JsonProperty("receipt_url")]
        public string ReceiptUrl { get; set; }
        [JsonProperty("suggest_email")]
        public string SuggestEmail { get; set; }
    }
}