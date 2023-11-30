using System.Linq.Expressions;
using ApiTuya.Domain.Entities;

namespace ApiTuya.Application.Services.Orders
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAll(CancellationToken cancellationToken);
        Task<Order?> GetByID(int id, CancellationToken cancellationToken);
        Task<Order> CreateOrder(Order entity, CancellationToken cancellationToken);
        Task<Order?> Delete(int id, CancellationToken cancellationToken);
        Task Update(Order entity, CancellationToken cancellationToken);
        Task<Order?> Find(Expression<Func<Order, bool>> expr, CancellationToken cancellationToken);
    }
}