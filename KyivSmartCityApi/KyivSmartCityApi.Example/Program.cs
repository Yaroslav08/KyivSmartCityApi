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
            KyivApiClient client = new KyivApiClient("eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwczpcL1wvYXBwLmt5aXZjaXR5Lmdvdi51YVwvYXV0aFwvY2FsbGJhY2siLCJpYXQiOjE2MDU1MjMzNzYsImV4cCI6MTYwODIwMTc3NiwibmJmIjoxNjA1NTIzMzc2LCJqdGkiOiJTY2kyYWV0eklHQVdlSnkyIiwic3ViIjoxMTA3MjEsInBydiI6IjIzYmQ1Yzg5NDlmNjAwYWRiMzllNzAxYzQwMDg3MmRiN2E1OTc2ZjcifQ.h8-KxwG_rOZztWTvSQ14EL13Ha8g7cpJJqFrpGP-Png");
            var feeds = await client.GetFeedsAsync();
            var cards = await client.GetTravelCardsAsync();
            var card = await client.GetTravelCardHistoryByIdAsync(cards.SmartCards.Last().Id);
        }
    }
}
