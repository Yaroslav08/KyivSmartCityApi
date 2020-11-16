using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace KyivSmartCityApi.Models
{
    public class Result
    {
        [JsonPropertyName("feed")]
        public List<Feed> Feed { get; set; }

        [JsonPropertyName("history")]
        public List<Trip> Trips { get; set; }
    }
}
