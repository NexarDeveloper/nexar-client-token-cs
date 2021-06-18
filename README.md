# Nexar.Client.Token

Getting Nexar Supply tokens for client ID and secret.

[nuget.org/packages/Nexar.Client.Token](https://www.nuget.org/packages/Nexar.Client.Token/)

## Example

```csharp
using Nexar.Client.Token;
using System.Net.Http;

using var client = new HttpClient();
string token = await client.GetNexarTokenAsync(clientId, clientSecret);
```

## See also

- [Sample/Program.cs](Sample/Program.cs) - simple demo console app
- [nexar-token-cs](https://github.com/NexarDeveloper/nexar-token-cs) - console app for getting various Nexar tokens
- [nexar-console-supply](https://github.com/NexarDeveloper/nexar-templates/tree/main/nexar-console-supply) - getting a token and using for operations
