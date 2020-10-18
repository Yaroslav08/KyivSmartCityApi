using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class ListDocuments
    {
        [JsonProperty("documents")]
        public List<Document> Documents { get; set; }
    }
}