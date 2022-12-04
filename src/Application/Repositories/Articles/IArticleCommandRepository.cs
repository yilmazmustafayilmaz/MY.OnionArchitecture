using Application.Repositories.BaseRepositories;
using Domain.Entities;

namespace Application.Repositories.Articles;

public interface IArticleCommandRepository : ICommandRepository<Article>
{
}
