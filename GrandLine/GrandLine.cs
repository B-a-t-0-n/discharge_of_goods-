using GrandLine.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime.Intrinsics.X86;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GrandLine
{
    public class GrandLine
    {
        public readonly string _apiKey;
        public Uri UriApi { get; private set; }
        public IEnumerable<Nomenclature>? Nomenclatures { get; private set; }
        public IEnumerable<Price>? Prices { get; private set; }
        public IEnumerable<Branche>? Banches { get; private set; }
        public IEnumerable<Agreement>? Agreements { get; private set; }

        public GrandLine(string apiKey)
        {
            _apiKey = apiKey;
            UriApi = new Uri("https://client.grandline.ru/api/public");
            UpdateBranches();
            UpdateAgreements();
            //UpdateNomenclatures(20);
            //UpdatePrice(20);
        }

        private void UpdateNomenclatures(int limit)
        {
            string requestUri = $"{UriApi}/nomenclatures/?api_key={_apiKey}&limit={limit}";

            using (HttpClient client = new HttpClient())
            {
                Nomenclatures = Task.Run(() => client.GetFromJsonAsync<IEnumerable<Nomenclature>>(requestUri)).Result;
            }
        }

        private void UpdatePrice(int limit)
        {
            string requestUri = $"{UriApi}/prices/?api_key={_apiKey}&nomenclature_id_1c={Nomenclatures!.First().id_1c}";

            Console.WriteLine(requestUri);

            using (HttpClient client = new HttpClient())
            {
                Console.WriteLine(client.GetStringAsync(requestUri).Result);
                //Prices = Task.Run(() => client.GetFromJsonAsync<IEnumerable<Price>>(requestUri)).Result;
            }

        }

        private void UpdateBranches()
        {
            string requestUri = $"{UriApi}/branches/?api_key={_apiKey}";

            Console.WriteLine(requestUri);

            using (HttpClient client = new HttpClient())
            {
                Banches = Task.Run(() => client.GetFromJsonAsync<IEnumerable<Branche>>(requestUri)).Result;
            }

        }

        private void UpdateAgreements()
        {
            string requestUri = $"{UriApi}/agreements/?api_key={_apiKey}";

            Console.WriteLine(requestUri);

            using (HttpClient client = new HttpClient())
            {
                Agreements = Task.Run(() => client.GetFromJsonAsync<IEnumerable<Agreement>>(requestUri)).Result;
            }

        }
    }
}