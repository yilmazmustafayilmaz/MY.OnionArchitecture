using Domain.Comman;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories.BaseRepositories;

public interface IBaseRepository<TEntity> where TEntity : BaseEntity
{
    DbSet<TEntity> Table { get; }
}

