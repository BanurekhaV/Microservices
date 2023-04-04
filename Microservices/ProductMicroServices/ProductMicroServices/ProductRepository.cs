using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductMicroServices
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> products = new List<Product>();

        public ProductRepository()
        {
            products.Add(new Product
            {
                Id=Guid.NewGuid(),
                PName="IPhone",
                Quantity=50,
                Price=125000,
            });
            products.Add(new Product
            {
                Id = Guid.NewGuid(),
                PName = "Redmi",
                Quantity = 150,
                Price = 34000,
            });
        }

        public Task<List<Product>>GetAllProducts()
        {
            return Task.FromResult(products);
        }
    }
}
