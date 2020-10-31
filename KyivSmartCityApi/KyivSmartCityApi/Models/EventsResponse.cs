using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class EventsResponse
    {
        [JsonProperty("events")]
        public Events Events { get; set; }
    }
}