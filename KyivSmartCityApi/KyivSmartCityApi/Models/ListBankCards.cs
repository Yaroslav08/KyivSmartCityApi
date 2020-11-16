using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class ListBankCards
    {
        [JsonPropertyName("cards")]
        public List<BankCard> BankCards { get; set; }
    }
}