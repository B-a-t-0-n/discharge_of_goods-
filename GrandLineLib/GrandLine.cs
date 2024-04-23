using GrandLineLib.Data;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Net.Http.Json;
namespace GrandLineLib
{
    public class GrandLine
    {
        public readonly string _apiKey;
        public Uri UriApi { get; private set; }
        public List<Nomenclature>? Nomenclatures { get; private set; } = new List<Nomenclature>();
        public List<Price>? Prices { get; private set; } = new List<Price>();
        public List<Branche>? Banches { get; private set; }
        public List<Agreement>? Agreements { get; private set; }

        public GrandLine(string apiKey)
        {
            _apiKey = apiKey;
            UriApi = new Uri("https://client.grandline.ru/api/public");
            UpdateBranches();
            UpdateAgreements();
            LoadFullNomenclatures();
            //UpdatePrice(4,0);


        }

        private void LoadFullNomenclatures()
        {
            int nomeraclanturesLength = NumberOfEntries("nomenclatures", "");
            for (int i = 0; i < nomeraclanturesLength; i += 20000)
            {
                UpdateNomenclatures(20000, i);
            }

        }

        private int NumberOfEntries(string nameTable, string additionalRequest)
        { 
            try
            {
                List<int> lastElem = new List<int>() { 1 };
                List<Object>? table;

                do
                {
                    string requestUri = $"{UriApi}/{nameTable}/?api_key={_apiKey}&limit=1&offset={lastElem.Sum()}{additionalRequest}";

                    using (HttpClient client = new HttpClient())
                    {
                        table = Task.Run(() => client.GetFromJsonAsync<List<Object>>(requestUri)).Result;
                    }

                    lastElem[lastElem.Count - 1] *= 10;

                } while (table!.Count != 0);

                lastElem[lastElem.Count - 1] /= 100;
                int temp = lastElem[lastElem.Count - 1];

                while (temp != 0)
                {
                    do
                    {
                        string requestUri = $"{UriApi}/{nameTable}/?api_key={_apiKey}&limit=1&offset={lastElem.Sum()}";

                        using (HttpClient client = new HttpClient())
                        {
                            table = Task.Run(() => client.GetFromJsonAsync<List<Object>>(requestUri)).Result;
                        }

                        lastElem[lastElem.Count - 1] += temp;

                    } while (table!.Count != 0);

                    lastElem[lastElem.Count - 1] -= temp * 2;
                    temp /= 10;
                    lastElem.Add(temp);
                }

                return lastElem.Sum() - 2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
            
        }

        private void UpdateNomenclatures(int limit, int offset)
        {
            string requestUri = $"{UriApi}/nomenclatures/?api_key={_apiKey}&limit={limit}&offset={offset}";

            Console.WriteLine(requestUri);

            using (HttpClient client = new HttpClient())
            {
                Nomenclatures!.AddRange(Task.Run(() => client.GetFromJsonAsync<List<Nomenclature>>(requestUri)).Result!);
            }
        }

        private void UpdatePrice(int limit, int offset, string agreementId1c, string branchId1c)
        {
            string requestUri = $"{UriApi}/prices/?api_key={_apiKey}&limit={limit}&offset={offset}&agreement_id_1c={agreementId1c}&branch_id_1c={branchId1c}";

            Console.WriteLine(requestUri);

            using (HttpClient client = new HttpClient())
            {
                Prices = Task.Run(() => client.GetFromJsonAsync<List<Price>>(requestUri)).Result;
            }

        }

        private void UpdateBranches()
        {
            string requestUri = $"{UriApi}/branches/?api_key={_apiKey}";

            Console.WriteLine(requestUri);

            using (HttpClient client = new HttpClient())
            {
                Banches = Task.Run(() => client.GetFromJsonAsync<List<Branche>>(requestUri)).Result;
            }

        }

        private void UpdateAgreements()
        {
            string requestUri = $"{UriApi}/agreements/?api_key={_apiKey}";

            Console.WriteLine(requestUri);

            using (HttpClient client = new HttpClient())
            {
                Agreements = Task.Run(() => client.GetFromJsonAsync<List<Agreement>>(requestUri)).Result;
            }

        }
    }
}