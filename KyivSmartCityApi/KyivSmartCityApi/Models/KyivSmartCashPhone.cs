using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class KyivSmartCashPhone
    {
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}