using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class CreateSmartCardModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("number")]
        public string Number { get; set; }
        [JsonProperty("pin")]
        public string Pin { get; set; }
    }
}