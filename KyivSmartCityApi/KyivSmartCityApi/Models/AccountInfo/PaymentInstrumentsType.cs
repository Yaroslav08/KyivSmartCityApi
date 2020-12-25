using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
namespace KyivSmartCityApi.Models.AccountInfo
{
    public class PaymentInstrumentsType
    {
        [JsonPropertyName("instrumentType")]
        public string InstrumentType { get; set; }
        [JsonPropertyName("commission")]
        public double Commission { get; set; }
        [JsonPropertyName("amountMin")]
        public double AmountMin { get; set; }
        [JsonPropertyName("amountMax")]
        public double AmountMax { get; set; }
        [JsonPropertyName("userPaymentInstruments")]
        public List<UserPaymentInstrument> UserPaymentInstruments { get; set; }
    }
}