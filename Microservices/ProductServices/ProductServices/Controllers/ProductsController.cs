using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/<ProductsController>
        [HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        public IEnumerable<ProductModel> Get()
        {
            ProductModel productmodel1 = new ProductModel();
            ProductModel productmodel2 = new ProductModel();

            productmodel1.ProductId = 1;
            productmodel1.ProductName = "Laptops";
            productmodel1.Description = "HP";
            productmodel1.Price = 56000;

            productmodel2.ProductId = 2;
            productmodel2.ProductName = "Laptops";
            productmodel2.Description = "Dell";
            productmodel2.Price = 54000;

            List<ProductModel> productlist = new List<ProductModel>();
            productlist.Add(productmodel1);
            productlist.Add(productmodel2);


            return productlist;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
