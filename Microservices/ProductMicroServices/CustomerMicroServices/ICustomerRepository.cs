using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerMicroServices
{
    public interface ICustomerRepository
    {
        public Task<List<Customer>> GetAllCustomers();
    }
}
