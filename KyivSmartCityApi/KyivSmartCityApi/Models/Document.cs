using KyivSmartCityApi.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Document
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("type_text")]
        public string TypeText { get; set; }
        [JsonProperty("series")]
        public string Series { get; set; }
        [JsonProperty("number")]
        public string Number { get; set; }
        [JsonProperty("issueDate")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime IssueDate { get; set; }
        [JsonProperty("issuedBy")]
        public string IssuedBy { get; set; }
        [JsonProperty("expiryDate")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime ExpiryDate { get; set; }
    }
}