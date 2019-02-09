using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Fingerprint.Impl
{
    public class BlockchainClient
    {
        private static string credString = GetCredString();
        private const string CLIENT_APP_Id = "512f4ef5-7702-48d5-b1d3-215b2fc48c73";
        private const string CLIENT_SECRET = "m-$@^@(MuN+?]M[Qs.)D&r0#As";
        private const string RESOURCE = "512f4ef5-7702-48d5-b1d3-215b2fc48c73";
        private const string AUTHORITY = "https://login.microsoftonline.com/a3ffb329-6cb4-406c-93ce-78b1de7da53d";
        private const string API_URL = "https://fpchain-6sgnhk-api.azurewebsites.net";

        private static string GetCredString()
        {
            AuthenticationContext authenticationContext = new AuthenticationContext(AUTHORITY);
            ClientCredential clientCredential = new ClientCredential(CLIENT_APP_Id, CLIENT_SECRET);

            var result = authenticationContext.AcquireTokenAsync(RESOURCE, clientCredential).Result;
            return result.AccessToken;
        }

        public async Task CreateToken(string signature)
        {
            var item = new UserDetails()
            {
                emailAddress = "test@test.com",
                firstName = "testFirstName",
                lastName = "testLastName",
                externalID = Guid.NewGuid().ToString()
            };
            var thisCreds = credString;
            using (var client = new HttpClient())
            {
                var requestMessage = new HttpRequestMessage();
                requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", thisCreds);
                requestMessage.Method = HttpMethod.Post;
                var content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                requestMessage.Content = content;

                var builder = new UriBuilder(API_URL);
                builder.Path = "/api/v1/users";
                requestMessage.RequestUri = builder.Uri;


                var resp  = await client.SendAsync(requestMessage);

                Console.WriteLine(resp.StatusCode);

            }

        }


        class UserDetails
        {
            public string externalID { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string emailAddress { get; set; }
        }
    }
}
