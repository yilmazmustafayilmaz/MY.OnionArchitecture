using Application.Repositories.BaseRepositories;
using Domain.Comman;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using System.Linq.Expressions;

namespace Persistence.Repositories.BaseRepositories;

public class QueryRepository<TEntity> : IQueryRepository<TEntity> where TEntity : BaseEntity
{
    private readonly Context _context;
    public QueryRepository(Context context)
    {
        _context = context;
    }
    public DbSet<TEntity> Table => _context.Set<TEntity>();

    public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (filter is not null) query = query.Where(filter);
        if (!tracking) query = query.AsNoTracking();
        return query;
    }

    public async Task<TEntity> GetByFilterAsync(Expression<Func<TEntity, bool>> filter, bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking) query = query.AsNoTracking();
        return await query.FirstOrDefaultAsync(filter);
    }

    public async Task<TEntity> GetByIdAsync(string id, bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking) query = query.AsNoTracking();
        return await query.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
    }
}


