using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FaqDetail
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("answer")]
        public List<Answer> Answers { get; set; }
        [JsonProperty("question")]
        public string Question { get; set; }
        [JsonProperty("voted_for")]
        public bool VotedFor { get; set; }
    }
}