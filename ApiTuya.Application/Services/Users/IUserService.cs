
using ApiTuya.Domain.Entities;

namespace ApiTuya.Application.Services.Users
{
    public interface IUserService
    {
        Task<User> Create(User createUser, CancellationToken cancellationToken);
        Task<User> Get(int id, CancellationToken cancellationToken);
        Task<ICollection<User>> GetAll(CancellationToken cancellationToken);
        Task<User> Update(User updateRequest, CancellationToken cancellationToken);
    }
}