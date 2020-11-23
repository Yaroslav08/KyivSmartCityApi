using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyivSmartCityApi.Models;

namespace KyivSmartCityApi.Example
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            KyivApiClient client = new KyivApiClient("{Your_Token}");
            var feeds = await client.GetFeedsAsync();
            var cards = await client.GetTravelCardsAsync();
        }
    }
}
