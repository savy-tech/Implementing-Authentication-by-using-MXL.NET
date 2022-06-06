using System;
using System.Threading.Tasks; 
using Microsoft.Identity.Client;

namespace az204App
{
    class Program
    {
        private const string _clientId = "08c1cbf5-4755-43cf-bdf1-61dfc2d2c901";
       
        private const string _tenantId = "97e84c6d-d397-437d-91f5-240646017107";
        
        public static async Task Main(string[] args)
        
        {
            var app = PublicClientApplicationBuilder
                .Create(_clientId) 
                .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
                .WithRedirectUri("http://localhost") 
                .Build();
            string[] scopes = { "user.read" };
            AuthenticationResult result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();
            Console.WriteLine($"Token:\t{result.AccessToken}");
            
            Console.WriteLine("I am in love with A.Z204 !");
        }
    }
}
