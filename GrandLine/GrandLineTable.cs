using GrandLine.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GrandLine
{
    public class GrandLineTable
    {
        public readonly string _apiKey;
        public Uri UriApi { get; private set; }
        public IEnumerable<Nomenclature>? Nomenclatures { get; private set; }
      
        public GrandLineTable(string apiKey) 
        {
            _apiKey = apiKey;
            UriApi = new Uri("https://client.grandline.ru/api/public");
            UpdateNomenclatures(20);
        }

        private void UpdateNomenclatures(int limit)
        {
            string requestUri = $"{UriApi}/nomenclatures/?api_key={_apiKey}&limit={limit}";

            Console.WriteLine(requestUri);

            using (HttpClient client = new HttpClient())
            {
                Nomenclatures = Task.Run(() => client.GetFromJsonAsync<IEnumerable<Nomenclature>>(requestUri)).Result;
            }
        }


    }
}
