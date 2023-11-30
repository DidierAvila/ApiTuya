using ApiTuya.Application.Services.Customers;
using ApiTuya.Application.Services.Orders;
using ApiTuya.Application.Services.Security;
using ApiTuya.Application.Services.TEntitys;
using ApiTuya.Application.Services.Users;
using ApiTuya.Infrastructure.Repositories.CustomerRepository;
using ApiTuya.Infrastructure.Repositories.OrderRepository;
using ApiTuya.Infrastructure.Repositories.TokenRepository;
using ApiTuya.Infrastructure.Repositories.UserRepository;

namespace ApiTuya.Extentions
{
    public static class ApiTuyaExtention
    {
        public static IServiceCollection AddApiTuyaExtention(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderRepository, OrderRepository>();

            services.AddScoped<ISecurityService, SecurityService>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<ITokenRepository, TokenRepository>();

            



            return services;
        }
    }
}