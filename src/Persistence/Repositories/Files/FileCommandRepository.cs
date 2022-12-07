using Application.Repositories.Files;
using Domain.Comman;
using Persistence.Contexts;
using Persistence.Repositories.BaseRepositories;

namespace Persistence.Repositories.Files;

public class FileCommandRepository : CommandRepository<BaseFile>, IFileCommandRepository
{
    public FileCommandRepository(Context context) : base(context) { }
}



