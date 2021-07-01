using Estore.Server.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Estore.Client.Services
{
    public class SellerServices
    {

        string baseUrl = "https://localhost:44381/";
        private readonly HttpClient httpClient;
        public SellerServices(HttpClient httpClient)
            => this.httpClient = httpClient;


        public async Task<HttpResponseMessage> isSeller(Seller p)
        {
            //HttpResponseMessage obj =await httpClient.PostAsync($"{baseUrl}api/Sellers/isSeller", getStringContentFromObject(p));
            return await httpClient.PostAsync($"{baseUrl}api/Sellers/isSeller", getStringContentFromObject(p));
        }
        public async Task<HttpResponseMessage> AddSeller(Seller p)
        {
            Console.WriteLine(p.Name);
            return await httpClient.PostAsync($"{baseUrl}api/Sellers/isSeller", getStringContentFromObject(p));

        }


        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");

            return stringContent;
        }


    }
}
