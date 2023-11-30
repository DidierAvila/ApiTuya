using System.Linq.Expressions;
using ApiTuya.Domain.Entities;
using ApiTuya.Infrastructure.Repositories.OrderRepository;

namespace ApiTuya.Application.Services.Orders
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _OrderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _OrderRepository = orderRepository;
        }

        public async Task<Order> CreateOrder(Order entity, CancellationToken cancellationToken)
        {
            Order entityOrder = await _OrderRepository.Create(entity, cancellationToken);
            return entityOrder;
        }

        public Task<Order?> Delete(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Order?> Find(Expression<Func<Order, bool>> expr, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Order>> GetAll(CancellationToken cancellationToken)
        {
            IEnumerable<Order> CurrentOrder = await _OrderRepository.GetAll(cancellationToken);
            if (CurrentOrder != null)
            {
                return CurrentOrder;
            }
            return null;
        }

        public async Task<Order?> GetByID(int id, CancellationToken cancellationToken)
        {
            Order? CurrentOrder = await _OrderRepository.GetByID(id, cancellationToken);
            if (CurrentOrder != null)
            {
                return CurrentOrder;
            }
            return null;
        }

        public async Task Update(Order entity, CancellationToken cancellationToken)
        {
            Order? CurrentOrder = await _OrderRepository.GetByID(entity.Id, cancellationToken);
            if (CurrentOrder != null)
            {
                await _OrderRepository.Update(entity, cancellationToken);
            }
        }
    }
}