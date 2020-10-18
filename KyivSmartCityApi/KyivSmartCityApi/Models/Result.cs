using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace KyivSmartCityApi.Models
{
    public class Result
    {
        [JsonProperty("feed")]
        public List<Feed> Feed { get; set; }

        [JsonProperty("history")]
        public List<Trip> Trips { get; set; }
    }
}
