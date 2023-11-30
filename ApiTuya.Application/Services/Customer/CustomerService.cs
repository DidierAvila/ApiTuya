using System.Linq.Expressions;
using ApiTuya.Application.Services.TEntitys;
using ApiTuya.Domain.Entities;
using ApiTuya.Infrastructure.Repositories.CustomerRepository;

namespace ApiTuya.Application.Services.Customers
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _CustomerRepository;
        
        public CustomerService(ICustomerRepository customerRepository)
        {
            _CustomerRepository = customerRepository;
        }

        public async Task<Customer> CreateCustomer(Customer entity, CancellationToken cancellationToken)
        {
            Customer EntityCustomer = await _CustomerRepository.Create(entity, cancellationToken);
            if (EntityCustomer != null)
            {
                return EntityCustomer; 
            }
            return null;
        }

        public Task<Customer?> Delete(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Customer>> GetAll(CancellationToken cancellationToken)
        {
            IEnumerable<Customer> CurrentCustomer = await _CustomerRepository.GetAll(cancellationToken);
            if (CurrentCustomer != null)
            {
                return CurrentCustomer;
            }
            return null;
        }

        public async Task<Customer?> GetByID(int id, CancellationToken cancellationToken)
        {
            Customer? CurrentCustomer = await _CustomerRepository.GetByID(id, cancellationToken);
            if (CurrentCustomer != null)
            {
                return CurrentCustomer;
            }
            return null;
        }

        public async Task Update(Customer entity, CancellationToken cancellationToken)
        {
            Customer? CurrentCustomer = await _CustomerRepository.GetByID(entity.Id, cancellationToken);
            if (CurrentCustomer != null)
            {
                await _CustomerRepository.Update(entity, cancellationToken);  
            }
        }
    }
}