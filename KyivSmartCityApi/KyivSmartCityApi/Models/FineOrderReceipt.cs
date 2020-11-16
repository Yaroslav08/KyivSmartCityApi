using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FineOrderReceipt
    {
        [JsonPropertyName("order_id")]
        public long OrderId { get; set; }
        [JsonPropertyName("receipt_url")]
        public string ReceiptUrl { get; set; }
        [JsonPropertyName("suggest_email")]
        public string SuggestEmail { get; set; }
    }
}