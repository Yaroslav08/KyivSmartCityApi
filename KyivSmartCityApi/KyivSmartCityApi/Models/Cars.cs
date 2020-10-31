using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Cars
    {
        [JsonProperty("cars")]
        public List<Car> ListCars { get; set; }
    }
}