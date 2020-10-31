using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class AddressPart
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}