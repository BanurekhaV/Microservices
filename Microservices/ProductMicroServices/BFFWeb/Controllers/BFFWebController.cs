using CustomerMicroServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProductMicroServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BFFWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BFFWebController : ControllerBase
    {
        [HttpGet("GetAllProducts")]

        public async Task<List<ProductDTO>> GetAllProducts()
        {
            return await GetAllProductsInternal();
        }

        private async Task<List<ProductDTO>> GetAllProductsInternal()
        {
            string baseUrl = "http://localhost:9230/api/";
            string url = baseUrl + "Product/GetAllProducts";

            using(HttpClient client = new HttpClient())
            {
                using(HttpResponseMessage responsemsg = await client.GetAsync(url))
                {
                    using(HttpContent content= responsemsg.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<List<ProductDTO>>(data);
                    }
                }
            }

        }


        [HttpGet("GetAllCustomers")]
        public async Task<List<CustomerDTO>> GetAllCustomers()
        {
            return await GetAllCustomersInternal();
        }

        private async Task<List<CustomerDTO>>
        GetAllCustomersInternal()
        {
            string baseURL = "http://localhost:1274/api/";
            string url = baseURL + "Customer/GetAllCustomers";
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage responseMessage = await client.GetAsync(url))
                {
                    using (HttpContent content = responseMessage.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<List<CustomerDTO>>(data);
                    }
                }
            }
        }
    }
}
