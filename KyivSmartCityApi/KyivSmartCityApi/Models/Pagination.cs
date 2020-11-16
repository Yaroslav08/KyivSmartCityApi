using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Pagination
    {
        [JsonPropertyName("count")]
        private int Count;
        [JsonPropertyName("currentPage")]
        private int CurrentPage;
        [JsonPropertyName("links")]
        private Links Links;
        [JsonPropertyName("perPage")]
        private int PerPage;
        [JsonPropertyName("total")]
        private int Total;
        [JsonPropertyName("totalPages")]
        private int TotalPages;
    }
}