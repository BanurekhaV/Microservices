using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductMicroServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository prodrepo;

        public ProductController(IProductRepository productrepo)
        {
            prodrepo = productrepo;
        }

        [HttpGet("GetAllProducts")]
        public async Task<List<Product>>GetAllProducts()
        {
            return await prodrepo.GetAllProducts();
        }
    }
}
