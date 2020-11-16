using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class EventsResponse
    {
        [JsonPropertyName("events")]
        public Events Events { get; set; }
    }
}