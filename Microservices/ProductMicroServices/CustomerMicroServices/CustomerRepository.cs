using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerMicroServices
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> customers = new List<Customer>();

        public CustomerRepository()
        {
            customers.Add(new Customer
            {
                Id = Guid.NewGuid(),
                FirstName="Kamal",
                LastName="Rajendra",
                Address="Mumbai",
                Phone="11111111111",

            });
            customers.Add(new Customer
            {
                Id = Guid.NewGuid(),
                FirstName = "Gauthami",
                LastName = "T",
                Address = "Bangalore",
                Phone = "222222222",

            });
        }

        public Task<List<Customer>> GetAllCustomers()
        {
            return Task.FromResult(customers);
        }
    }
}
