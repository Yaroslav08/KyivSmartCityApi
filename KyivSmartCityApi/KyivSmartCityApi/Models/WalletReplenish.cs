using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class WalletReplenish
    {
        [JsonProperty("balance_wallet")]
        public int BalanceWallet { get; set; }
        [JsonProperty("cards")]
        public List<BankCard> Cards { get; set; }
    }
}