using Estore.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Estore.Shared;
using System.Text;
using Newtonsoft.Json;

namespace Estore.Client.Services
{
    public class ProductServices
    {
        string baseUrl = "https://localhost:44381/";
        private readonly HttpClient httpClient;
        public ProductServices(HttpClient httpClient)
            => this.httpClient = httpClient;

        public async Task<Catalog> GetProduct()
        {
            
            Product[] products  = await this.httpClient.GetFromJsonAsync<Product[]>("api/Products/ShowProducts");
            Console.WriteLine(products);
            return new Catalog { Products = products.ToList() }; 
        }

        public async Task<HttpResponseMessage> AddProduct( Product p)
        {
            Console.WriteLine(p.Name);
            return await httpClient.PostAsync($"{baseUrl}api/products/AddProduct", getStringContentFromObject(p));
            
        }


        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");

            return stringContent;
        }
    }
}
