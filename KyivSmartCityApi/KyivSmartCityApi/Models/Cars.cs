using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Cars
    {
        [JsonPropertyName("cars")]
        public List<Car> ListCars { get; set; }
    }
}