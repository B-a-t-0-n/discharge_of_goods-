using DockeLib.Data;
using RestSharp;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace DockeLib
{
    public class Docke
    {
        public string ApiToken { get; private set; } = null!;
        public Uri UriApi { get; set; }

        public List<Contragents> Contragents { get; private set; } = null!;
        public List<Factories> Factories { get; private set; } = null!;
        public List<Agrees> Agrees { get; private set; } = null!;

        public Docke(string login, string password)
        {
            UriApi = new Uri("https://b2b.docke.ru");
            Update(login, password);
        }

        private async Task<User> Auth(string login, string password)
        {
            var client = new RestClient(UriApi);
            var request = new RestRequest("/api/client/auth");

            UserAuth userAuth = new UserAuth()
            {
                login = login,
                password = password
            };

            request.AddBody(JsonSerializer.Serialize(userAuth));

            User? user = await client.PostAsync<User>(request);

            return user!;
        }

        private void Update(string login, string password)
        {
            var user = Auth(login, password).Result;
            ApiToken = user.data!.token!;
            Contragents = user.data!.contragent!;
            Factories = user.data!.factories!;
            Agrees = user.data!.agrees!;
        }
    }
}
