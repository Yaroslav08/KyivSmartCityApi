using KyivSmartCityApi.Settings;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Document
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("type_text")]
        public string TypeText { get; set; }
        [JsonPropertyName("series")]
        public string Series { get; set; }
        [JsonPropertyName("number")]
        public string Number { get; set; }
        [JsonPropertyName("issueDate")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime IssueDate { get; set; }
        [JsonPropertyName("issuedBy")]
        public string IssuedBy { get; set; }
        [JsonPropertyName("expiryDate")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime ExpiryDate { get; set; }
    }
}