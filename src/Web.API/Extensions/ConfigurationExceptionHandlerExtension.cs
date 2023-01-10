using Microsoft.AspNetCore.Diagnostics;
using System.Net;
using System.Net.Mime;
using System.Text.Json;

namespace Web.API.Extensions;

public static class ConfigurationExceptionHandlerExtension
{
    public static void ConfigurationExceptionHandler<TEntity>(this WebApplication app, ILogger<TEntity> logger)
    {
        app.UseExceptionHandler(builder =>
        {
            builder.Run(async context =>
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = MediaTypeNames.Application.Json;

                var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                if (contextFeature != null)
                {
                    logger.LogError(contextFeature.Error.Message);

                    await context.Response.WriteAsync(JsonSerializer.Serialize(new
                    {
                        Title = "Hata oluştu!",
                        Message = contextFeature.Error.Message,
                        StatusCode = context.Response.StatusCode
                    }));
                }
            });
        });
    }
}
