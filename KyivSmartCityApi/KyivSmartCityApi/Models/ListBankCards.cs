using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class ListBankCards
    {
        [JsonProperty("cards")]
        public List<BankCard> BankCards { get; set; }
    }
}