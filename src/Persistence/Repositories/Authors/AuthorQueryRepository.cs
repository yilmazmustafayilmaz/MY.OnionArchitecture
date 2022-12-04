using Application.Repositories.Authors;
using Domain.Entities;
using Persistence.Contexts;
using Persistence.Repositories.BaseRepositories;

namespace Persistence.Repositories.Authors;

public class AuthorQueryRepository : QueryRepository<Author>, IAuthorQueryRepository
{
    public AuthorQueryRepository(Context context) : base(context) { }
}


