 using ApiTuya.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTuya.Domain.BussinesRule
{
    internal interface OrderManagement
    {
        Task<Order> CancelOrderByPolicy20000(int orderId, CancellationToken cancellationToken);
        Task<Order> RescheduleDeliveryOrder(int orderId, CancellationToken cancellationToken);
        Task<Order> ChangePolicesOrder(int orderId, CancellationToken cancellationToken);
    }
}
