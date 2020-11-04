using System;
using CleanArchitecture.Service.Repositories;
using CleanArchitecture.Service.Repositories.Domain;

namespace CleanArchitecture.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly Random _random = new Random();
        
        public Customer GetByFirstAndLastName(string firstName, string lastName)
        {
            return new Customer
            {
                Id = _random.Next(1, 10000),
                FirstName = firstName,
                LastName = lastName
            };
        }
    }
}