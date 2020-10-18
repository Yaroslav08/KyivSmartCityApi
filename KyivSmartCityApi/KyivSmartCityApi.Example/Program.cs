using System;
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
            KyivApiClient client = new KyivApiClient("eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwczpcL1wvYXBwLmt5aXZjaXR5Lmdvdi51YVwvYXV0aFwvY2FsbGJhY2siLCJpYXQiOjE2MDMwMjk5NzYsImV4cCI6MTYwNTcwODM3NiwibmJmIjoxNjAzMDI5OTc2LCJqdGkiOiJJVFRhcWd3ZTZ4OVdIZHgzIiwic3ViIjoxMTA3MjEsInBydiI6IjIzYmQ1Yzg5NDlmNjAwYWRiMzllNzAxYzQwMDg3MmRiN2E1OTc2ZjcifQ.Udsa9HNZuk6dzTfVa69zZulahgTJEjamFPcTpy7Xnxw");
            //var feeds = await client.GetFeedsAsync();
            //foreach (var feed in feeds)
            //{
            //    Console.WriteLine($"[Id: {feed.Id}]\t[Title: {feed.Title}]\t[Description: {feed.Description}]");
            //}
            //var feedItem = await client.GetFeedAsync(feeds.First().Id);
            //Console.WriteLine($"[Id: {feedItem.Id}]\t[Title: {feedItem.Title}]\t[Description: {feedItem.Description}]");

            var cards = await client.GetTravelCardsAsync();

        }
    }
}
