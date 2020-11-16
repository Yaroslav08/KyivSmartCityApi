using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace KyivSmartCityApi.Models
{
    public class Phone 
    {
        [JsonPropertyName("phone")]
        public string phone { get; set; }
    }
}
