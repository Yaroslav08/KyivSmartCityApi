using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace KyivSmartCityApi.Models
{
    public class SmartCardInfo
    {
        [JsonProperty("card")]
        public SmartCard SmartCard { get; set; }
        [JsonProperty("feed")]
        public List<Feed> Feeds { get; set; }
    }
}
