using Application.Services;
using Application.Storages;
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
    }
    public static void AddStorage<TStorage>(this IServiceCollection services) where TStorage : Storage, IStorage
    {
        services.AddScoped<IStorage, TStorage>();
    }
}


