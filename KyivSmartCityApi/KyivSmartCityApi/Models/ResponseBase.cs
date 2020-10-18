using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class ResponseBase
    {
        [JsonProperty("success")]
        public bool IsSuccess { get; set; }
    }
}