using Application.Repositories.BaseRepositories;
using Domain.Comman;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repositories.BaseRepositories;

public class CommandRepository<TEntity> : ICommandRepository<TEntity> where TEntity : BaseEntity
{
    private readonly Context _context;
    public CommandRepository(Context context)
    {
        _context = context;
    }

    public DbSet<TEntity> Table => _context.Set<TEntity>();

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        await Table.AddAsync(entity);
        return entity;
    }

    public async Task<bool> AddRangeAsync(List<TEntity> entities)
    {
        await Table.AddRangeAsync(entities);
        return true;
    }

    public TEntity Remove(TEntity entity)
    {
        Table.Remove(entity);
        return entity;
    }

    public async Task<TEntity> RemoveByIdAsync(string id)
    {
        var entity = await Table.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
        return Remove(entity);
    }

    public bool RemoveRange(List<TEntity> entities)
    {
        Table.RemoveRange(entities);
        return true;
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public TEntity Update(TEntity entity)
    {
        Table.Update(entity);
        return entity;
    }
}


