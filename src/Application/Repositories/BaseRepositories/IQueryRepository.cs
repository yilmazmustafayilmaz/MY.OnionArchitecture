using Domain.Comman;
using System.Linq.Expressions;

namespace Application.Repositories.BaseRepositories;

public interface IQueryRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
{
    IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, bool tracking = true);
    Task<TEntity> GetByFilterAsync(Expression<Func<TEntity, bool>> filter, bool tracking = true);
    Task<TEntity> GetByIdAsync(string id, bool tracking = true);
}

