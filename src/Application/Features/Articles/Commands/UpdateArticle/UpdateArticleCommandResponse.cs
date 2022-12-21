namespace Application.Features.Articles.Commands.UpdateArticle;

public record UpdateArticleCommandResponse
{
    public Guid Id { get; set; }
    public Guid AuthorId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime UpdatedDate { get; set; }
}

