using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
namespace KyivSmartCityApi.Models.AccountInfo
{
    public class UserPaymentInstrument
    {
        [JsonPropertyName("instrumentId")]
        public int InstrumentId { get; set; }
        [JsonPropertyName("instrumentType")]
        public string InstrumentType { get; set; }
        [JsonPropertyName("instrumentValue")]
        public string InstrumentValue { get; set; }
        [JsonPropertyName("alias")]
        public string Alias { get; set; }
        [JsonPropertyName("commission")]
        public int Commission { get; set; }
        [JsonPropertyName("loyaltyCommission")]
        public string LoyaltyCommission { get; set; }
        [JsonPropertyName("actionsKeys")]
        public string ActionsKeys { get; set; }
        [JsonPropertyName("priorityIndex")]
        public int PriorityIndex { get; set; }
        [JsonPropertyName("additionalParams")]
        public string[] AdditionalParams { get; set; }
    }
}