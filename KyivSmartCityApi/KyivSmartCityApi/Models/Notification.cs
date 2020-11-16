using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Notification
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("text")]
        public string Text { get; set; }
        [JsonPropertyName("link")]
        public string Link { get; set; }
        [JsonPropertyName("button")]
        public string Button { get; set; }
    }
}