using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Events
    {
        [JsonPropertyName("data")]
        public List<Data> EventList { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }
}