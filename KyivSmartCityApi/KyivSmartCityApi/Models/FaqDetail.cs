using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FaqDetail
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("answer")]
        public List<Answer> Answers { get; set; }
        [JsonPropertyName("question")]
        public string Question { get; set; }
        [JsonPropertyName("voted_for")]
        public bool VotedFor { get; set; }
    }
}