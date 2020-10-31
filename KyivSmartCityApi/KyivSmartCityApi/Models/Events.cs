using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Events
    {
        [JsonProperty("data")]
        public List<Data> EventList { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}