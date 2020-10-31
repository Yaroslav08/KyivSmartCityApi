using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FinesPaymentFeed
    {
        [JsonProperty("payments")]
        public FinesFeedData Payments { get; set; }
    }
}