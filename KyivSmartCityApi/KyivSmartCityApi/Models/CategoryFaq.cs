using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class CategoryFaq
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("faqs")]
        public List<FaqTopic> FaqTopics { get; set; }
    }
}