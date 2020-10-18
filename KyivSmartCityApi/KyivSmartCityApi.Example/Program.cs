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
            KyivApiClient client = new KyivApiClient("eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwczpcL1wvYXBwLmt5aXZjaXR5Lmdvdi51YVwvYXV0aFwvY2FsbGJhY2siLCJpYXQiOjE2MDMwMzM3NDcsImV4cCI6MTYwNTcxMjE0NywibmJmIjoxNjAzMDMzNzQ3LCJqdGkiOiI5clptSTRzQzZWYVVjNkRoIiwic3ViIjoyOTA2NjUsInBydiI6IjIzYmQ1Yzg5NDlmNjAwYWRiMzllNzAxYzQwMDg3MmRiN2E1OTc2ZjcifQ.kcVBgIG7o5mhZVXPO-cpLYasOhW4moHc5Q5U1StzgrM");
            var docs = await client.GetDocumentsAsync();
            var doc = await client.GetDocumentAsync(docs.Documents.First().Id);
        }
    }
}
