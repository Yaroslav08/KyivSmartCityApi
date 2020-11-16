using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class MonthlyTicketPurchase
    {
        [JsonPropertyName("available_month")]
        public byte AvailableMonth { get; set; }
        [JsonPropertyName("half_a_month")]
        public bool HalfAMonth { get; set; }
    }
}