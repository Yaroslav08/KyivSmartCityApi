using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
namespace KyivSmartCityApi.Models.AccountInfo
{
    public class BankingDetails
    {
        [JsonPropertyName("payee")]
        public Payee Payee { get; set; }
        [JsonPropertyName("payer")]
        public string Payer { get; set; }
        [JsonPropertyName("narrative")]
        public Narrative Narrative { get; set; }
    }
}