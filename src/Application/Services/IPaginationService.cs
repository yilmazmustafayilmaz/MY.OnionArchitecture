using Application.Paginate;
using Domain.Comman;

namespace Application.Services;

public interface IPaginationService<TEntity> where TEntity : BaseEntity
{
    IList<TEntity> ListPagination(IList<TEntity> entities, Pagination pagination);
    IQueryable<TEntity> QueryablePagination(IQueryable<TEntity> entities, Pagination pagination);
    IEnumerable<TEntity> EnumerablePagination(IEnumerable<TEntity> entities, Pagination pagination);
}


