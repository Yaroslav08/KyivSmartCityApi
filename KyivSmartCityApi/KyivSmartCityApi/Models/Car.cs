using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Car
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("label")]
        public string Label { get; set; }
        [JsonPropertyName("main")]
        public bool IsMain { get; set; }
        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("session_active_since")]
        public long SessionActiveSince { get; set; }
        [JsonPropertyName("session_lasts_for")]
        public long SessionLastFor { get; set; }
        [JsonPropertyName("ticket_period")]
        public string TicketPeriod { get; set; }
        [JsonPropertyName("tickets")]
        public List<CarTicket> Tickets { get; set; }
        [JsonPropertyName("usual_format")]
        public bool UsualFormat { get; set; }
        [JsonPropertyName("verified")]
        public bool IsVerified { get; set; }
    }
}