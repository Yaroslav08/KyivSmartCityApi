using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class ProjectStatus
    {
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}