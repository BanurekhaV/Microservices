using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        // GET: api/<CustomersController>
        [HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        public IEnumerable<CustomerModel> Get()
        {
            CustomerModel customermodel1 = new CustomerModel();
            CustomerModel customermodel2 = new CustomerModel();

            customermodel1.CustomerId = 100;
            customermodel1.CustomerName = "Ben Jones";
            customermodel1.CustomerPhone = 11111111;

            customermodel2.CustomerId = 101;
            customermodel2.CustomerName = "Robert Clive";
            customermodel2.CustomerPhone = 2222222;

            List<CustomerModel> customerlist = new List<CustomerModel>();
            customerlist.Add(customermodel1);
            customerlist.Add(customermodel2);

            return customerlist;

        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
