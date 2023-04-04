using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerMicroServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerRepository custrepo;

        public CustomerController(ICustomerRepository customerrepo)
        {
            custrepo = customerrepo;
        }

        [HttpGet("GetAllCustomers")]
        public async Task<List<Customer>>GetAllCustomers()
        {
            return await custrepo.GetAllCustomers();
        }
    }
}
