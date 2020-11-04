using System;
using CleanArchitecture.Data.Repositories;
using CleanArchitecture.Service.Bootstrap;
using CleanArchitecture.Service.Services;

namespace CleanArchitecture
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerRepository customerRepository = new CustomerRepository();
            CustomerService customerService = new CustomerService(customerRepository);
             
            var bootstrapClient = new BootstrapClient(customerService);
            
            Bootstrap bootstrap = new Bootstrap(bootstrapClient);
            bootstrap.Start();
        }
    }
}