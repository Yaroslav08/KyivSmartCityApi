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
        public AccountInfo Info { get; set; }
    }
}