namespace Application.Services;

public interface IAuthorHubService
{
    Task AuthorAddedMessageAsync(string message);
}


