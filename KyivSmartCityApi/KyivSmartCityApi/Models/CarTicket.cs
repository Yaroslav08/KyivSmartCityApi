using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class CarTicket
    {
        [JsonPropertyName("period")]
        public string Period { get; set; }
        [JsonPropertyName("zone")]
        public int Zone { get; set; }
    }
}