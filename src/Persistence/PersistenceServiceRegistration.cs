using Application.Repositories.Articles;
using Application.Repositories.Authors;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories.Articles;
using Persistence.Repositories.Authors;

namespace Persistence;

public static class PersistenceServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services, IConfiguration Configuration)
    {
        services.AddDbContext<Context>(opt => opt.UseNpgsql(Configuration.GetConnectionString("PostgreSql")));

        //Article
        services.AddScoped<IArticleCommandRepository, ArticleCommandRepository>();
        services.AddScoped<IArticleQueryRepository, ArticleQueryRepository>();
        //Author
        services.AddScoped<IAuthorCommandRepository, AuthorCommandRepository>();
        services.AddScoped<IAuthorQueryRepository, AuthorQueryRepository>();
    }
}


