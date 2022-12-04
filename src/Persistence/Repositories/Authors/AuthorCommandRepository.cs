using Application.Repositories.Authors;
using Domain.Entities;
using Persistence.Contexts;
using Persistence.Repositories.BaseRepositories;

namespace Persistence.Repositories.Authors;

public class AuthorCommandRepository : CommandRepository<Author>, IAuthorCommandRepository
{
    public AuthorCommandRepository(Context context) : base(context) { }
}


