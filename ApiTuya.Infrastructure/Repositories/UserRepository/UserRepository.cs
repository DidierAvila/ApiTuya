
using ApiTuya.Domain.Entities;
using ApiTuya.Infrastructure.DbContexts;

namespace ApiTuya.Infrastructure.Repositories.UserRepository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(ApiTuyaDbContext context) : base(context)
        {
        }
    }
}