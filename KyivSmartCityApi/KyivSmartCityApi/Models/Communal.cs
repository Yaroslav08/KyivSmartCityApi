using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Communal
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("full_name")]
        public string Fullname { get; set; }
        [JsonProperty("pib")]
        public object Pib { get; set; }
        [JsonProperty("company")]
        public string Company { get; set; }
        [JsonProperty("debt")]
        public int Debt { get; set; }
        [JsonProperty("counters")]
        public List<Counter> Counters { get; set; }


    }
    public class Counter
    {
        [JsonProperty("number")]
        public string Number { get; set; }
        [JsonProperty("old")]
        public int Old { get; set; }
    }
}