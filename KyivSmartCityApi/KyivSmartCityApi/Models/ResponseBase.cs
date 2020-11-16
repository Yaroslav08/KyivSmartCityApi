using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class ResponseBase
    {
        [JsonPropertyName("success")]
        public bool IsSuccess { get; set; }
    }
}