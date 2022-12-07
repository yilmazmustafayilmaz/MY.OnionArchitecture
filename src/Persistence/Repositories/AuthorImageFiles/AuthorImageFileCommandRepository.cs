using Application.Repositories.AuthorImagesFiles;
using Domain.Entities;
using Persistence.Contexts;
using Persistence.Repositories.BaseRepositories;

namespace Persistence.Repositories.AuthorImageFiles;

public class AuthorImageFileCommandRepository : CommandRepository<AuthorImageFile>, IAuthorImageFileCommandRepository
{
    public AuthorImageFileCommandRepository(Context context) : base(context) { }
}



