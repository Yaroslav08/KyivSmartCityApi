using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class CarTicket
    {
        [JsonProperty("period")]
        public string Period { get; set; }
        [JsonProperty("zone")]
        public int Zone { get; set; }
    }
}