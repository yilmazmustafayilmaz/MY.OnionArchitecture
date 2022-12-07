using Application.Repositories.AuthorImagesFiles;
using Domain.Entities;
using Persistence.Contexts;
using Persistence.Repositories.BaseRepositories;

namespace Persistence.Repositories.AuthorImageFiles;

public class AuthorImageFileQueryRepository : QueryRepository<AuthorImageFile>, IAuthorImageFileQueryRepository
{
    public AuthorImageFileQueryRepository(Context context) : base(context) { }
}



