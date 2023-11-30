using System.Linq.Expressions;
using ApiTuya.Domain.Entities;

namespace ApiTuya.Application.Services.TEntitys
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAll(CancellationToken cancellationToken);
        Task<Customer?> GetByID(int id, CancellationToken cancellationToken);
        Task<Customer> CreateCustomer(Customer entity, CancellationToken cancellationToken);
        Task<Customer?> Delete(int id, CancellationToken cancellationToken);
        Task Update(Customer entity, CancellationToken cancellationToken);
        Task<Customer?> Find(Expression<Func<Customer, bool>> expr, CancellationToken cancellationToken);
    }
}