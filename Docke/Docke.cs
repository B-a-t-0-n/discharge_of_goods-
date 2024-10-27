using DockeLib.Data;
using DockeLib.DataRequest;
using DockeLib.Exel.Data;
using RestSharp;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text.Json;

namespace DockeLib
{
    public class Docke
    {
        public string ApiToken { get; private set; } = null!;
        public Uri UriApi { get; set; }

        public List<Contragents> Contragents { get; private set; } = null!;
        public List<Factories> Factories { get; private set; } = null!;
        public List<Agrees> Agrees { get; private set; } = null!;
        public List<Product> Products { get; private set; } = new List<Product>();
        public List<PriceProductRpp> Prices { get; private set; } = new List<PriceProductRpp>();
        public List<PriceProductRpp> PricesRRP { get; private set; } = new List<PriceProductRpp>();
        public UserAuth UserAuth { get; set; } = new UserAuth();

        public Docke(string login, string password)
        {
            UriApi = new Uri("https://b2b.docke.ru");
            UserAuth.login = login;
            UserAuth.password = password;

            UpdateUser();
        }

        public async Task UpdateAll(string agree_uuid, string factory_uuid, int speed, bool canBuy)
        {
            if (speed < 1 || speed > 5000)
                throw new Exception("скорость должна быть в пределе от 1 до 5000");

            UpdateUser();

            RequestPrice requestPrice = new RequestPrice()
            {
                agree_uuid = agree_uuid,
                factory_uuid = factory_uuid
            };

            RequestProduct requestProduct = new RequestProduct()
            {
                agree_uuid = agree_uuid,
                factory_uuid = factory_uuid,
                page = 1,
                can_buy = canBuy,
                offset = speed
            };

            await UpdateProduct(requestPrice, requestProduct);
        }

        private User Auth()
        {
            var client = new RestClient(UriApi);
            var request = new RestRequest("/api/client/auth");

            request.AddBody(JsonSerializer.Serialize(UserAuth));

            User? user = client.Post<User>(request);

            return user!;
        }

        private void UpdateUser()
        {
            var user = Auth();
            ApiToken = user.data!.token!;
            Contragents = user.data!.contragent!;
            Factories = user.data!.factories!;
            Agrees = user.data!.agrees!;
        }

        private async Task<T> GetDataAsync<T>(System.Object Body, string resource, T value)
        {
            var client = new RestClient(UriApi);
            var request = new RestRequest(resource);

            request.AddHeader("Authorization", ApiToken);
            request.AddBody(JsonSerializer.Serialize(Body));

            var data = await client.PostAsync<T>(request);

            return data!;
        }

        private async Task UpdateProduct(RequestPrice requestPrice, RequestProduct requestProduct)
        {
            ListProducts listProducts;
            do
            {
                listProducts = await GetDataAsync(requestProduct, "/api/client/product/get", new ListProducts());
                Products.AddRange(listProducts.products!.ToList());
                requestProduct.page++;
            } while (listProducts.products!.Count() > 0);

            var pricesProducts = await GetDataAsync(requestPrice, "/api/client/prices/get", new Prices());

            var prices = new PricesRpp();
            prices.prices = new List<PriceProductRpp>();

            foreach (var price in pricesProducts.prices!)
            {
                var product = Products.FirstOrDefault(i => i.vendor == price.vendor);
                var list = prices.prices as List<PriceProductRpp>;
                list!.Add(
                    new PriceProductRpp()
                    {
                        vendor = price.vendor,
                        measure = price.prices!.FirstOrDefault(i => i.measure == product!.measure)!.measure,
                        price = price.prices!.FirstOrDefault(i => i.measure == product!.measure)!.price
                    }
                );
            }
            
            Prices = prices.prices!.ToList();

            var pricesRrpProducts = await GetDataAsync(requestPrice, "/api/client/prices/rrp/get", new PricesRpp());
            PricesRRP = pricesRrpProducts.prices!.ToList();
        }
    }
}
