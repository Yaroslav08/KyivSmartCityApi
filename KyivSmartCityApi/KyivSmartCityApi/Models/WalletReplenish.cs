using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class WalletReplenish
    {
        [JsonPropertyName("balance_wallet")]
        public int BalanceWallet { get; set; }
        [JsonPropertyName("cards")]
        public List<BankCard> Cards { get; set; }
    }
}