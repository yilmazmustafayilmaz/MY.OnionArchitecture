namespace Application.Features.Articles.Commands.CreateArticle;

public record CreateArticleCommandResponse
{
    public Guid Id { get; set; }
    public Guid AuthorId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
}


