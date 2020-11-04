using CleanArchitecture.Service.Repositories.Domain;

namespace CleanArchitecture.Service.Repositories
{
    public interface ICustomerRepository
    {
        public Customer GetByFirstAndLastName(string firstName, string lastName);
    }
}