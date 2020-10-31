using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Car
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("label")]
        public string Label { get; set; }
        [JsonProperty("main")]
        public bool IsMain { get; set; }
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("session_active_since")]
        public long SessionActiveSince { get; set; }
        [JsonProperty("session_lasts_for")]
        public long SessionLastFor { get; set; }
        [JsonProperty("ticket_period")]
        public string TicketPeriod { get; set; }
        [JsonProperty("tickets")]
        public List<CarTicket> Tickets { get; set; }
        [JsonProperty("usual_format")]
        public bool UsualFormat { get; set; }
        [JsonProperty("verified")]
        public bool IsVerified { get; set; }
    }
}