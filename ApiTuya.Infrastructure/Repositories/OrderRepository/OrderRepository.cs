using ApiTuya.Domain.Entities;
using ApiTuya.Infrastructure.DbContexts;

namespace ApiTuya.Infrastructure.Repositories.OrderRepository
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(ApiTuyaDbContext context) : base(context)
        {
        }
    }
}