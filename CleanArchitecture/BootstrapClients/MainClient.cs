using System;
using CleanArchitecture.Service.Bootstrap;
using CleanArchitecture.Service.Services;

namespace CleanArchitecture
{
    public class BootstrapClient : IBootstrapClient
    {
        private readonly CustomerService _customerService;

        public BootstrapClient(CustomerService customerService)
        {
            _customerService = customerService;
        }

        public void Start()
        {
            var randomCustomers = this._customerService.GetRandomCustomers();

            foreach (var customer in randomCustomers)
            {
                Console.WriteLine($"{customer.Id} - {customer.FirstName} {customer.LastName}");
            }

            Console.ReadKey();
        }
    }
}