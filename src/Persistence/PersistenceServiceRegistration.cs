using Application.Repositories.Articles;
using Application.Repositories.AuthorImagesFiles;
using Application.Repositories.Authors;
using Application.Repositories.Files;
using Application.Services;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories.Articles;
using Persistence.Repositories.AuthorImageFiles;
using Persistence.Repositories.Authors;
using Persistence.Repositories.Files;
using Persistence.Services;

namespace Persistence;

public static class PersistenceServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services, IConfiguration Configuration)
    {
        services.AddDbContext<Context>(opt => opt.UseNpgsql(Configuration.GetConnectionString("PostgreSql")));

        services.AddIdentity<AppUser, AppRole>(options =>
        {
            options.Password.RequiredLength = 3;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireDigit = false;
            options.Password.RequireUppercase = false;
        }).AddEntityFrameworkStores<Context>();

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
        //User
        services.AddScoped<IUserService, UserService>();
        //Auth
        services.AddScoped<IAuthService, AuthService>();
    }
}


