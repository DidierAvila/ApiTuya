using ApiTuya.Domain.Entities;
using ApiTuya.Infrastructure.DbContexts;

namespace ApiTuya.Infrastructure.Repositories.TokenRepository
{
    public class TokenRepository : RepositoryBase<Token>, ITokenRepository
    {
        public TokenRepository(ApiTuyaDbContext context) : base(context)
        {
        }
    }
}