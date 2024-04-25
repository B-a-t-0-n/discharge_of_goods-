using GrandLineLib.Data;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
namespace GrandLineLib
{
    public class GrandLine
    {
        public readonly string _apiKey;
        public Uri UriApi { get; private set; }
        public List<Nomenclature>? Nomenclatures { get; private set; } = new List<Nomenclature>();
        public List<Price>? Prices { get; private set; } = new List<Price>();
        public List<Branche>? Branches { get; private set; }
        public List<Agreement>? Agreements { get; private set; }

        public GrandLine(string apiKey, bool downnloadingData = true)
        {
            _apiKey = apiKey;
            UriApi = new Uri("https://client.grandline.ru/api/public");

            UpdateBranches();
            UpdateAgreements();

            if( downnloadingData )
                FullLoadingUpdatingOfTables([Agreements!.First().id_1c], [Branches!.First().id_1c]);

        }

        public void FullLoadingUpdatingOfTables(string[] agreementId1c, string[] branchId1c)
        {
            Nomenclatures = new List<Nomenclature>();
            Prices = new List<Price>();
            Branches = new List<Branche>();
            Agreements = new List<Agreement>();

            UpdateBranches();
            UpdateAgreements();
            LoadFullNomenclatures();
            for (int i = 0; i < agreementId1c.Length; i++)
            {
                for (int j = 0; j < branchId1c.Length; j++)
                {
                    LoadFullPrices(agreementId1c[i], branchId1c[j]);
                }
            }
            
        }

        private void LoadFullPrices(string agreementId1c, string branchId1c)
        {
            int pricesLength = NumberOfEntries("prices", $"&agreement_id_1c={agreementId1c}&branch_id_1c={branchId1c}");

            for (int k = 0; k < pricesLength; k += 20000)
            {
                UpdatePrice(20000, k, agreementId1c, branchId1c);
            }
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
                        string requestUri = $"{UriApi}/{nameTable}/?api_key={_apiKey}&limit=1&offset={lastElem.Sum()}{additionalRequest}";

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

            using (HttpClient client = new HttpClient())
            {
                Nomenclatures!.AddRange(Task.Run(() => client.GetFromJsonAsync<List<Nomenclature>>(requestUri)).Result!);
            }
        }

        private void UpdatePrice(int limit, int offset, string agreementId1c, string branchId1c)
        {
            string requestUri = $"{UriApi}/prices/?api_key={_apiKey}&limit={limit}&offset={offset}&agreement_id_1c={agreementId1c}&branch_id_1c={branchId1c}";

            using (HttpClient client = new HttpClient())
            {
                Prices!.AddRange(Task.Run(() => client.GetFromJsonAsync<List<Price>>(requestUri)).Result!);
            }

        }

        private void UpdateBranches()
        {
            string requestUri = $"{UriApi}/branches/?api_key={_apiKey}";

            using (HttpClient client = new HttpClient())
            {
                Branches = Task.Run(() => client.GetFromJsonAsync<List<Branche>>(requestUri)).Result;
            }

        }

        private void UpdateAgreements()
        {
            string requestUri = $"{UriApi}/agreements/?api_key={_apiKey}";

            using (HttpClient client = new HttpClient())
            {
                Agreements = Task.Run(() => client.GetFromJsonAsync<List<Agreement>>(requestUri)).Result;
            }

        }
    }
}