using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Interfaces;
using Interfaces.Prebuild;

namespace Domain
{
    public class CustomerReadonlyRepository : IReadonlyRepository<Customer, Guid, CustomerQuery>
    {
        public Task<Customer> GetByKey(Guid key)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> Query(CustomerQuery query)
        {
            throw new NotImplementedException();
        }
    }
}