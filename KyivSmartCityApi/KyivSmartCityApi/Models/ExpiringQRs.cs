using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class ExpiringQRs
    {
        [JsonProperty("feed_item")]
        public Feed Feed { get; set; }
        [JsonProperty("qrs")]
        public List<QrCode> Qrs { get; set; }
    }
}