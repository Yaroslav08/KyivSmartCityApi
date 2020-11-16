using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class CommunalAddresses
    {
        [JsonPropertyName("objects")]
        public Object[] Objects { get; set; }
    }
    public class Object
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("address")]
        public string Address { get; set; }
        [JsonPropertyName("debt")]
        public int Debt { get; set; }
    }
}