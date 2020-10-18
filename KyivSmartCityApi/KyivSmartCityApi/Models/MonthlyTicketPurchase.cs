using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class MonthlyTicketPurchase
    {
        [JsonProperty("available_month")]
        public byte AvailableMonth { get; set; }
        [JsonProperty("half_a_month")]
        public bool HalfAMonth { get; set; }
    }
}