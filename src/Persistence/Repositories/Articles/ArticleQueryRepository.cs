using Application.Repositories.Articles;
using Domain.Entities;
using Persistence.Contexts;
using Persistence.Repositories.BaseRepositories;

namespace Persistence.Repositories.Articles;

public class ArticleQueryRepository : QueryRepository<Article>, IArticleQueryRepository
{
    public ArticleQueryRepository(Context context) : base(context) { }
}


