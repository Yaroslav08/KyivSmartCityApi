using System;
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
            KyivApiClient client = new KyivApiClient("eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwczpcL1wvYXBwLmt5aXZjaXR5Lmdvdi51YVwvYXV0aFwvY2FsbGJhY2siLCJpYXQiOjE2MDI5NTk0NDksImV4cCI6MTYwNTYzNzg0OSwibmJmIjoxNjAyOTU5NDQ5LCJqdGkiOiJkeFRlcWFjdFE2N2ZKVjNlIiwic3ViIjoyNjY4MzcsInBydiI6IjIzYmQ1Yzg5NDlmNjAwYWRiMzllNzAxYzQwMDg3MmRiN2E1OTc2ZjcifQ.qeYWclonqyiNznKLgFWbVr6fnCl8Nv-hkH9cPSq8VOg");
            var feeds = await client.GetFeedsAsync();
            foreach (var feed in feeds)
            {
                Console.WriteLine($"[Id: {feed.Id}]\t[Title: {feed.Title}]\t[Description: {feed.Description}]");
            }
        }
    }
}
