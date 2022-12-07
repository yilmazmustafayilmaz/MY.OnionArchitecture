using Application.Repositories.Files;
using Domain.Comman;
using Persistence.Contexts;
using Persistence.Repositories.BaseRepositories;

namespace Persistence.Repositories.Files;

public class FileQueryRepository : QueryRepository<BaseFile>, IFileQueryRepository
{
    public FileQueryRepository(Context context) : base(context) { }
}



