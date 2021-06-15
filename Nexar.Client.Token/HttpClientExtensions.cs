using IdentityModel.Client;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Nexar.Client.Token
{
    public static class HttpClientExtensions
    {
        public static async Task<string> GetNexarTokenAsync(
            this HttpClient httpClient,
            string clientId,
            string clientSecret,
            string authority = "https://identity.nexar.com/")
        {
            if (httpClient == null)
                throw new ArgumentNullException(nameof(httpClient));
            if (clientId == null)
                throw new ArgumentNullException(nameof(clientId));
            if (clientSecret == null)
                throw new ArgumentNullException(nameof(clientSecret));
            if (authority == null)
                throw new ArgumentNullException(nameof(authority));

            var tokenEndpoint = new Uri(authority).AbsoluteUri + "connect/token";
            using (var request = new ClientCredentialsTokenRequest { Address = tokenEndpoint, ClientId = clientId, ClientSecret = clientSecret })
            {
                var tokenResponse = await httpClient.RequestClientCredentialsTokenAsync(request);
                var token = tokenResponse.AccessToken;
                if (token == null)
                    throw new InvalidOperationException("Cannot get Nexar token.");

                return token;
            }
        }
    }
}
