using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
namespace KyivSmartCityApi.Models.AccountInfo
{
    public class AccountInfoResponse
    {
        [JsonPropertyName("accountInfo")]
        public AccountInfo AccountInfo { get; set; }
        [JsonPropertyName("bankingDetails")]
        public BankingDetails BankingDetails { get; set; }

        [JsonPropertyName("fieldsData")]
        public List<string> FieldsData { get; set; }

        [JsonPropertyName("amount")]
        public double Amount { get; set; }
        [JsonPropertyName("amountMax")]
        public double AmountMax { get; set; }
        [JsonPropertyName("amountMin")]
        public double AmountMin { get; set; }

        [JsonPropertyName("preOrderInfo")]
        public string PreOrderInfo { get; set; }
        [JsonPropertyName("masterPassWalletStatus")]
        public string MasterPassWalletStatus { get; set; }
        [JsonPropertyName("masterPassCommission")]
        public double MasterPassCommission { get; set; }
        [JsonPropertyName("fieldsLists")]
        public string[] FieldsLists { get; set; }
        [JsonPropertyName("error")]
        public string Error { get; set; }
    }
}