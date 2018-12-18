using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Interfaces;
using Interfaces.Prebuild;

namespace Domain
{
    public class CustomerRepository : ICrudRepository<Customer, Guid, CustomerQuery>
    {
        public Task<Customer> GetByKey(Guid key)
        {
            throw new NotImplementedException();
        }

        public Task Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> Query(CustomerQuery query)
        {
            throw new NotImplementedException();
        }
    }
}