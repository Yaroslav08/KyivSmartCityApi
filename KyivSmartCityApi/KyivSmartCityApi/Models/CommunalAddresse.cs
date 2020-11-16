using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class CommunalAddresse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("address")]
        public string Address { get; set; }
        [JsonPropertyName("debt")]
        public int Debt { get; set; }
        [JsonPropertyName("debts_period")]
        public string DebtPeriod { get; set; }
        [JsonPropertyName("debts")]
        public List<Communal> Communals { get; set; }
    }
}