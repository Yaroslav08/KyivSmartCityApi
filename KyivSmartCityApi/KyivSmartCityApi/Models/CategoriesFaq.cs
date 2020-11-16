using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class CategoriesFaq
    {
        [JsonPropertyName("link_1551")]
        public string Link1551 { get; set; }
        [JsonPropertyName("categories")]
        public List<CategoryFaq> CategoryFaqs { get; set; }
    }
}