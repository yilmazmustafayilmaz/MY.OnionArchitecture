using Application.Services;
using Infrastructure.SignalR;
using Infrastructure.SignalR.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace Infrastructure.Services;

public class ArticleHubService : IArticleHubService
{
    private readonly IHubContext<ArticleHub> _hubContext;

    public ArticleHubService(IHubContext<ArticleHub> hubContext) => _hubContext = hubContext;
    
    public async Task ArticleAddedMessageAsync(string message) => await _hubContext.Clients.All
        .SendAsync(ReceiveFunctionNames.ArticleAddedMessage, message);
}


