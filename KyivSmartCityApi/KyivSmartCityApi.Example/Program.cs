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
            KyivApiClient client = new KyivApiClient("eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwczpcL1wvYXBwLmt5aXZjaXR5Lmdvdi51YVwvYXV0aFwvY2FsbGJhY2siLCJpYXQiOjE2MDMxMTg1NTgsImV4cCI6MTYwNTc5Njk1OCwibmJmIjoxNjAzMTE4NTU4LCJqdGkiOiJIZzRvN0RPU2FkOUZxWFVRIiwic3ViIjoxMTA3MjEsInBydiI6IjIzYmQ1Yzg5NDlmNjAwYWRiMzllNzAxYzQwMDg3MmRiN2E1OTc2ZjcifQ.NX9ErGWHqpbOlxyG7QzQZ2hUSyb1aXXvnppByv3nYEU");
            //var feeds = await client.GetFeedsAsync();
            //var cards = await client.GetTravelCardsAsync();
            //var card = await client.GetTravelCardHistoryAsync(cards.SmartCards.Last().Id);
        }
    }
}
