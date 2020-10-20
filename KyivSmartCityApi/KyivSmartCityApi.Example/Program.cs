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
            KyivApiClient client = new KyivApiClient("eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwczpcL1wvYXBwLmt5aXZjaXR5Lmdvdi51YVwvYXBpXC9hdXRoXC9yZWZyZXNoIiwiaWF0IjoxNjAzMTE4NTU4LCJleHAiOjE2MDU4NjgxMTksIm5iZiI6MTYwMzE4OTcxOSwianRpIjoidU05dWw4dzl0aWNQYm0yZCIsInN1YiI6MTEwNzIxLCJwcnYiOiIyM2JkNWM4OTQ5ZjYwMGFkYjM5ZTcwMWM0MDA4NzJkYjdhNTk3NmY3In0.ub7wOdLAD8PG4r2a4OLb4dS_PuXj8MfhSL0sJppPYc8");
            //var feeds = await client.GetFeedsAsync();
            //var cards = await client.GetTravelCardsAsync();
            //var card = await client.GetTravelCardHistoryAsync(cards.SmartCards.Last().Id);
        }
    }
}
