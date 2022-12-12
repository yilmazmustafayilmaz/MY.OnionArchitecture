using MediatR;

namespace Application.Features.Articles.Commands.CreateArticle;

public record CreateArticleCommandRequest : IRequest<CreateArticleCommandResponse>
{
    public Guid AuthorId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}


