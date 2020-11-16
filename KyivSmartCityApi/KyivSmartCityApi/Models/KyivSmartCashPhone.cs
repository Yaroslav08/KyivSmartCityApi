using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class KyivSmartCashPhone
    {
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    }
}