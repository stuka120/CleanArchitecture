using System.Collections.Generic;
using System.Linq;
using CleanArchitecture.Service.Repositories;
using CleanArchitecture.Service.Repositories.Domain;

namespace CleanArchitecture.Service.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<Customer> GetRandomCustomers()
        {
            return Enumerable.Range(1, 100)
                .Select(x => this._customerRepository.GetByFirstAndLastName(x.ToString(), x.ToString()));
        }
    }
}