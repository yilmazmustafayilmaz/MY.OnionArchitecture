using Application.Abstract.Services;
using Application.Abstract.Storages;
using Application.Services;
using Infrastructure.Services;
using Infrastructure.Storages;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static void AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IStorageService, StorageService>();
        services.AddScoped<ITokenHandlerService, TokenHandlerService>();
        services.AddScoped(typeof(IPaginationService<>), typeof(PaginationService<>));

        services.AddSignalR();
        services.AddScoped<IArticleHubService, ArticleHubService>();
        services.AddScoped<IAuthorHubService, AuthorHubService>();
        services.AddScoped<IMailService, MailService>();
    }
    public static void AddStorage<TStorage>(this IServiceCollection services) where TStorage : Storage, IStorage
    {
        services.AddScoped<IStorage, TStorage>();
    }
}


