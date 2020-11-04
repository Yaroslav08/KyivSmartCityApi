using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Link
    {
        [JsonProperty("icon")]
        private string Icon { get; set; }
        [JsonProperty("text")]
        private string Text { get; set; }
        [JsonProperty("url")]
        private string Url { get; set; }
    }
}