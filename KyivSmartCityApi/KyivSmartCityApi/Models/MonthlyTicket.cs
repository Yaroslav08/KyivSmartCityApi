using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class MonthlyTicket
    {
        [JsonProperty("balance")]
        public int Balance { get; set; }
        [JsonProperty("valid_until")]
        public int ValidTo { get; set; }
    }
}