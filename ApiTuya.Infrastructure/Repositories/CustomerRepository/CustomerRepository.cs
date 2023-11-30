using ApiTuya.Domain.Entities;
using ApiTuya.Infrastructure.DbContexts;

namespace ApiTuya.Infrastructure.Repositories.CustomerRepository
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApiTuyaDbContext context) : base(context)
        {
        }
    }
}