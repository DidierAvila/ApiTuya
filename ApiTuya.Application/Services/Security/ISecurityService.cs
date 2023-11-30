
using ApiTuya.Domain.Dtos.Users;

namespace ApiTuya.Application.Services.Security
{
    public interface ISecurityService
    {
        Task<LoginResponse> Login(LoginRequest autorizacion, CancellationToken cancellationToken);
    }
}