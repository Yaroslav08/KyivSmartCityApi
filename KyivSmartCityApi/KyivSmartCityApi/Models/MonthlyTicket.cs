using KyivSmartCityApi.Settings;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class MonthlyTicket
    {
        [JsonPropertyName("balance")]
        public int Balance { get; set; }
        [JsonPropertyName("valid_until")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime ValidTo { get; set; }
    }
}