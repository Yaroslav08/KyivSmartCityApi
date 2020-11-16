using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FaqTopic
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("question")]
        public string Question { get; set; }
    }
}