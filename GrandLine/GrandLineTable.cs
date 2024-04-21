using GrandLine.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace GrandLine
{
    public class GrandLineTable
    {
        public readonly string _apiKey;
        //private IEnumerable<Nomenclature> _nomenclatures;
        public IEnumerable<Nomenclature> Nomenclatures = new List<Nomenclature>();
        //public IEnumerable<Nomenclature> Nomenclatures
        //{
        //    get
        //    {
        //        return _nomenclatures;
        //    }
        //    set 
        //    {
        //        _nomenclatures = value;
        //    }
        //}
        private HttpClient httpClient = new HttpClient();

        public GrandLineTable(string apiKey) 
        {
            _apiKey = apiKey;
            //_nomenclatures = new List<Nomenclature>();
            //int limit = 1;
            //var test = httpClient.GetFromJsonAsync($"https://client.grandline.ru/api/public/nomenclatures/?api_key={_apiKey}&limit={limit}");
            //Console.WriteLine(test.Result);
            GetNomenclatures(1000);
        }

        private async Task GetNomenclatures(int limit)
        {
            Nomenclatures = await httpClient.GetFromJsonAsync<List<Nomenclature>>($"https://client.grandline.ru/api/public/nomenclatures/?api_key={_apiKey}&limit={limit}");
        }


    }
}
