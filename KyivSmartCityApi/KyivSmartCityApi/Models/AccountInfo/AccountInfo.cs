using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
namespace KyivSmartCityApi.Models.AccountInfo
{
    public class AccountInfo
    {
        [JsonPropertyName("Номер картки")]
        public string CardNumber { get; set; }
        [JsonPropertyName("Кількість поїздок")]
        public string NumberOfTrips { get; set; }
        [JsonPropertyName("Баланс на гаманці")]
        public string BalanceOnTheWallet { get; set; }
    }
}