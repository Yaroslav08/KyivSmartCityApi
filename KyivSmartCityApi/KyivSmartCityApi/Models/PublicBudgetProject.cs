using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class PublicBudgetProject
    {
        [JsonPropertyName("id")]
        public int id;
        [JsonPropertyName("author")]
        public string Author;
        [JsonPropertyName("budget")]
        public int Budget;
        [JsonPropertyName("category")]
        public PublicBudgetProjectCategory Category;
        [JsonPropertyName("name")]
        public string Name;
        [JsonPropertyName("status")]
        public ProjectStatus Status;
        [JsonPropertyName("voted")]
        public bool IsVoted;
        [JsonPropertyName("votes")]
        public int Votes;
    }
}