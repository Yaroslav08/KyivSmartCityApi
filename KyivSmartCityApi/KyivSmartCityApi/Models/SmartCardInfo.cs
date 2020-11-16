using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace KyivSmartCityApi.Models
{
    public class SmartCardInfo
    {
        [JsonPropertyName("card")]
        public SmartCard SmartCard { get; set; }
        [JsonPropertyName("feed")]
        public List<Feed> Feeds { get; set; }
    }
}
