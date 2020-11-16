using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Communal
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("full_name")]
        public string Fullname { get; set; }
        [JsonPropertyName("pib")]
        public object Pib { get; set; }
        [JsonPropertyName("company")]
        public string Company { get; set; }
        [JsonPropertyName("debt")]
        public int Debt { get; set; }
        [JsonPropertyName("counters")]
        public List<Counter> Counters { get; set; }


    }
    public class Counter
    {
        [JsonPropertyName("number")]
        public string Number { get; set; }
        [JsonPropertyName("old")]
        public int Old { get; set; }
    }
}