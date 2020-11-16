using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class ListDocuments
    {
        [JsonPropertyName("documents")]
        public List<Document> Documents { get; set; }
    }
}