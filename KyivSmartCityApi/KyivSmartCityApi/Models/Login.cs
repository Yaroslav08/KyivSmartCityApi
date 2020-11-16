using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace KyivSmartCityApi.Models
{
    public class Login
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    }
}
