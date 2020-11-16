using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FinesPaymentFeed
    {
        [JsonPropertyName("payments")]
        public FinesFeedData Payments { get; set; }
    }
}