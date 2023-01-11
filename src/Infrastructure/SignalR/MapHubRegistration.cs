using Infrastructure.SignalR.Hubs;
using Microsoft.AspNetCore.Builder;

namespace Infrastructure.SignalR;

public static class MapHubRegistration
{
    public static void MapHubs(this WebApplication app)
    {
        app.MapHub<ArticleHub>("/articles-hub");
    }
}


