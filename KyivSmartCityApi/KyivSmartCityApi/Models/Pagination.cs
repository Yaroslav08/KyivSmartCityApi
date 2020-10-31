using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Pagination
    {
        [JsonProperty("count")]
        private int Count;
        [JsonProperty("currentPage")]
        private int CurrentPage;
        [JsonProperty("links")]
        private Links Links;
        [JsonProperty("perPage")]
        private int PerPage;
        [JsonProperty("total")]
        private int Total;
        [JsonProperty("totalPages")]
        private int TotalPages;
    }
}