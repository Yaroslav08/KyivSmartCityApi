using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
namespace KyivSmartCityApi.Models.AccountInfo
{
    public class AccountInfoRequest
    {
        [JsonPropertyName("fields")]
        public List<FieldDetail> Fields { get; set; }

        [JsonPropertyName("serviceKey")]
        public string Key { get; set; } = "KYIVSMARTCARD";
        [JsonPropertyName("amount")]
        public string Amount { get; set; } = null;
        [JsonPropertyName("multyCheckPaymentStepIndex")]
        public int MultyCheckPaymentStepIndex { get; set; } = 0;

        public AccountInfoRequest(string number)
        {
            Fields = new List<FieldDetail>
            {
                new FieldDetail
                {
                    Name = "Account",
                    Value = number
                },
                new FieldDetail
                {
                    Name = "Agreement",
                    Value = "50"
                }
            };
        }
    }
}