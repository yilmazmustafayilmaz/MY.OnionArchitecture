using Domain.Comman;

namespace Application.Repositories.BaseRepositories;

public interface ICommandRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
{
    Task<TEntity> AddAsync(TEntity entity);
    Task<bool> AddRangeAsync(List<TEntity> entities);
    TEntity Remove(TEntity entity);
    Task<TEntity> RemoveByIdAsync(string id);
    bool RemoveRange(List<TEntity> entities);
    TEntity Update(TEntity entity);
    Task<int> SaveChangesAsync();
}

