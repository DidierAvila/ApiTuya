using ApiTuya.Application.Services.Orders;
using ApiTuya.Domain.Entities;
using ApiTuya.Infrastructure.Repositories.OrderRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApiTuyaTest
{
    public class OrderTest
    {
        private readonly IOrderService _OrderService;

        public OrderTest(IOrderService orderService) 
        {
            _OrderService = orderService;
        }

        [Fact]
        public void ValidatePlanOrder()
        {
            Order order = new Order
            {
                Id = 1,
                CustomerId = 1,
                Status = "creado",
                Radicado = "000020"
            };

            var result = _OrderService.ValidatePlanOrder(order);

            Assert.True(result);
        }
    }
}
