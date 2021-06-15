using Nexar.Client.Token;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (args.Length != 2)
                throw new InvalidOperationException("Usage: clientId clientSecret");

            var clientId = args[0];
            var clientSecret = args[1];

            using var client = new HttpClient();
            var token = await client.GetNexarTokenAsync(clientId, clientSecret);

            Console.WriteLine(token);
        }
    }
}
