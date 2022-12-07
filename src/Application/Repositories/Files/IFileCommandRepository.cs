using Application.Repositories.BaseRepositories;
using Domain.Comman;

namespace Application.Repositories.Files;

public interface IFileCommandRepository : ICommandRepository<BaseFile>
{
}
