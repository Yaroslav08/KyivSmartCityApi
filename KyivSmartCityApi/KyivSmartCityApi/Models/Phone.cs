using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace KyivSmartCityApi.Models
{
    public class Phone 
    {
        [JsonProperty("phone")]
        public string phone { get; set; }
    }
}
