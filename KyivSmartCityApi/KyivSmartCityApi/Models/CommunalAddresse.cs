using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class CommunalAddresse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("debt")]
        public int Debt { get; set; }
        [JsonProperty("debts_period")]
        public string DebtPeriod { get; set; }
        [JsonProperty("debts")]
        public List<Communal> Communals { get; set; }
    }
}