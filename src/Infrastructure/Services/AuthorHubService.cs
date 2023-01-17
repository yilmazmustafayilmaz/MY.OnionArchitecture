using Application.Services;
using Infrastructure.SignalR;
using Infrastructure.SignalR.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace Infrastructure.Services;

public class AuthorHubService : IAuthorHubService
{
    private readonly IHubContext<AuthorHub> _hubContext;

    public AuthorHubService(IHubContext<AuthorHub> hubContext) => _hubContext = hubContext;

    public async Task AuthorAddedMessageAsync(string message) => await _hubContext.Clients.All.SendAsync(ReceiveFunctionNames.AuthorAddedMessage, message);
}


