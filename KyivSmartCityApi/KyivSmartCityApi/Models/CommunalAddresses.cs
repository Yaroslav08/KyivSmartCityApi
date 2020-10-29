using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class CommunalAddresses
    {
        [JsonProperty("objects")]
        public Object[] Objects { get; set; }
    }

    public class Object
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("debt")]
        public int Debt { get; set; }
    }

}