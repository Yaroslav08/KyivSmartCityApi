using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class QrCodes
    {
        [JsonProperty("total")]
        public int Total { get; set; }
        [JsonProperty("codes")]
        public List<QrCode> Codes { get; set; }
    }
}