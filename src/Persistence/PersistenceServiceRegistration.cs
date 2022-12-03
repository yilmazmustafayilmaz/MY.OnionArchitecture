using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;

namespace Persistence;

public static class PersistenceServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services, IConfiguration Configuration)
    {
        services.AddDbContext<Context>(opt => opt.UseNpgsql(Configuration.GetConnectionString("PostgreSql")));
    }
}


