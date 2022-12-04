using Application.Repositories.BaseRepositories;
using Domain.Entities;

namespace Application.Repositories.Authors;

public interface IAuthorCommandRepository : ICommandRepository<Author>
{
}


