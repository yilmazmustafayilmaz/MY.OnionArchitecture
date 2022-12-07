using Application.Repositories.Articles;
using Application.Repositories.AuthorImagesFiles;
using Application.Repositories.Authors;
using Application.Repositories.Files;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories.Articles;
using Persistence.Repositories.AuthorImageFiles;
using Persistence.Repositories.Authors;
using Persistence.Repositories.Files;

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
        //AuthorImageFile
        services.AddScoped<IAuthorImageFileCommandRepository, AuthorImageFileCommandRepository>();
        services.AddScoped<IAuthorImageFileQueryRepository, AuthorImageFileQueryRepository>();
        //File
        services.AddScoped<IFileCommandRepository, FileCommandRepository>();
        services.AddScoped<IFileQueryRepository, FileQueryRepository>();
    }
}


