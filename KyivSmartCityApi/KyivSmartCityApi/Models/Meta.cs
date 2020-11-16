using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Meta
    {
        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }
    }
}