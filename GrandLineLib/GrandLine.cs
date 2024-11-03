using GrandLineLib.Data;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text.Json;

namespace GrandLineLib
{
    public class GrandLine
    {
        public readonly string _apiKey;
        public Uri UriApi { get; private set; }
        public List<Nomenclature> Nomenclatures { get; private set; } = new List<Nomenclature>();
        public List<Price> Prices { get; private set; } = new List<Price>();
        public List<Branche> Branches { get; private set; } = new List<Branche>();
        public List<Agreement> Agreements { get; private set; } = new List<Agreement>();

        public GrandLine(string apiKey)
        {
            _apiKey = apiKey;
            UriApi = new Uri("https://client.grandline.ru/api/public");
        }

        public async Task InitializeAsync()
        {
            Branches.AddRange(await GetDataAsync<Branche>($"/branches/?api_key={_apiKey}"));
            Agreements.AddRange(await GetDataAsync<Agreement>($"/agreements/?api_key={_apiKey}"));
        }

        private async Task<List<T>> GetDataAsync<T>(string requestUrl)
        {
            var url = UriApi + requestUrl;

            using HttpClient client = new HttpClient();
            var data = await client.GetFromJsonAsync<List<T>>(url);
            
            return data ?? new List<T>();
        }


        public async Task FullLoadingUpdatingOfTables(string agreementId1c, string branchId1c, int numberOfObjects)
        {
            Nomenclatures.Clear();
            Prices.Clear();
            Branches.Clear();
            Agreements.Clear();

            var tasks = new List<Task>
            {
                GetDataAsync<Branche>($"/branches/?api_key={_apiKey}"),
                GetDataAsync<Agreement>($"/agreements/?api_key={_apiKey}"),
                LoadFullNomenclatures(numberOfObjects),
                LoadFullPrices(agreementId1c, branchId1c, numberOfObjects)
            };

            await Task.WhenAll(tasks);
        }

        private async Task LoadFullPrices(string agreementId1c, string branchId1c, int numberOfObjects)
        {
            int offset = 0;
            int maxCountRequests = 20;

            while (true)
            {
                var tasks = new List<Task<List<Price>>>();
                for (int i = 0; i < maxCountRequests; i++)
                {
                    tasks.Add(GetDataAsync<Price>($"/prices/?api_key={_apiKey}&limit={numberOfObjects}&offset={offset + numberOfObjects * i}&agreement_id_1c={agreementId1c}&branch_id_1c={branchId1c}"));
                }

                var results = await Task.WhenAll(tasks);

                foreach (var prices in results)
                {
                    Prices.AddRange(prices);
                    if (prices.Count == 0)
                        return;
                }

                offset += numberOfObjects * maxCountRequests;
            }

        }

        private async Task LoadFullNomenclatures(int numberOfObjects)
        {
            int offset = 0;
            const int maxCountRequests = 20;

            while(true)
            {
                var tasks = new List<Task<List<Nomenclature>>>();

                for (int i = 0; i < maxCountRequests; i++)
                {
                    tasks.Add(GetDataAsync<Nomenclature>($"/nomenclatures/?api_key={_apiKey}&limit={numberOfObjects}&offset={offset + numberOfObjects * i}"));
                }

                var results = await Task.WhenAll(tasks);

                foreach (var result in results)
                {
                    Nomenclatures.AddRange(result);
                    if (result.Count == 0)
                        return;
                }

                offset += numberOfObjects * maxCountRequests;
            }
        }
    }
}