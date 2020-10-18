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
            KyivApiClient client = new KyivApiClient("eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwczpcL1wvYXBwLmt5aXZjaXR5Lmdvdi51YVwvYXV0aFwvY2FsbGJhY2siLCJpYXQiOjE2MDMwNDkwNzgsImV4cCI6MTYwNTcyNzQ3OCwibmJmIjoxNjAzMDQ5MDc4LCJqdGkiOiJPQTFyVEd3bUFOZk83SFlUIiwic3ViIjoxMTA3MjEsInBydiI6IjIzYmQ1Yzg5NDlmNjAwYWRiMzllNzAxYzQwMDg3MmRiN2E1OTc2ZjcifQ.MQNMdnlkIxvi45l44_nAKV1128A1qc-neNoyxhZoNHs");
            var feeds = await client.GetFeedsAsync();
        }
    }
}
