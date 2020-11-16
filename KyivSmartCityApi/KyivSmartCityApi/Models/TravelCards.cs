using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace KyivSmartCityApi.Models
{
    public class TravelCards
    {
        [JsonPropertyName("qrs_total")]
        public int QRsTotal { get; set; }
        [JsonPropertyName("cards")]
        public List<SmartCard> SmartCards { get; set; }
    }
}
