namespace Application.Services;

public interface IArticleHubService
{
    Task ArticleAddedMessageAsync(string message);
}


