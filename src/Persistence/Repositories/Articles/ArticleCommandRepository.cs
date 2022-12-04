using Application.Repositories.Articles;
using Domain.Entities;
using Persistence.Contexts;
using Persistence.Repositories.BaseRepositories;

namespace Persistence.Repositories.Articles;

public class ArticleCommandRepository : CommandRepository<Article>, IArticleCommandRepository
{
    public ArticleCommandRepository(Context context) : base(context) { }
}


