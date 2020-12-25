using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
namespace KyivSmartCityApi.Models.AccountInfo
{
    public class FieldDetail
    {
        [JsonPropertyName("fieldName")]
        public string Name { get; set; }
        [JsonPropertyName("fieldValue")]
        public string Value { get; set; }
    }
}