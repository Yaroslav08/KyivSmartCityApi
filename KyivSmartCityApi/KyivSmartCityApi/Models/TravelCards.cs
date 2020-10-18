using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace KyivSmartCityApi.Models
{
    public class TravelCards
    {
        [JsonProperty("qrs_total")]
        public int QRsTotal { get; set; }
        [JsonProperty("cards")]
        public List<SmartCard> SmartCards { get; set; }
    }
}
