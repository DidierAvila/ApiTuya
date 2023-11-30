using System.Linq.Expressions;

namespace ApiTuya.Infrastructure.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll(CancellationToken cancellationToken);
        Task<TEntity?> GetByID(int id, CancellationToken cancellationToken);
        Task<TEntity> Create(TEntity entity, CancellationToken cancellationToken);
        Task<TEntity?> Delete(int id, CancellationToken cancellationToken);
        Task Update(TEntity entity, CancellationToken cancellationToken);
        Task<TEntity?> Find(Expression<Func<TEntity, bool>> expr, CancellationToken cancellationToken);
    }
}