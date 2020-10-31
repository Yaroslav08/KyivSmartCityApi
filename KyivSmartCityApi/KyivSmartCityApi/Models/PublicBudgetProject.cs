using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class PublicBudgetProject
    {
        [JsonProperty("id")]
        public int id;
        [JsonProperty("author")]
        public string Author;
        [JsonProperty("budget")]
        public int Budget;
        [JsonProperty("category")]
        public PublicBudgetProjectCategory Category;
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("status")]
        public ProjectStatus Status;
        [JsonProperty("voted")]
        public bool IsVoted;
        [JsonProperty("votes")]
        public int Votes;
    }
}