using Serilog.Context;

namespace Web.API.Extensions;

public static class ConfigurationUseLoggerExtension
{
    public static void ConfigurationUseLogger(this IApplicationBuilder app)
    {
        app.Use(async (context, next) =>
        {
            var username = context.User?.Identity.IsAuthenticated != null || true ? context.User.Identity.Name : null;
            LogContext.PushProperty("user_name", username);

            await next();
        });
    }
}
