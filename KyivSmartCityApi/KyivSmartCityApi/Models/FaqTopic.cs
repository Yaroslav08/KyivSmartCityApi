using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FaqTopic
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("question")]
        public string Question { get; set; }
    }
}