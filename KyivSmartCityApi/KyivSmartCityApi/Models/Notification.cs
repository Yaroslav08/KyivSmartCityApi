using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Notification
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("link")]
        public string Link { get; set; }
        [JsonProperty("button")]
        public string Button { get; set; }
    }
}