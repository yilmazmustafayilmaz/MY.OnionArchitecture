using MediatR;

namespace Application.Features.Articles.Commands.RemoveArticle;

public record RemoveArticleCommandRequest(Guid Id) : IRequest<RemoveArticleCommandResponse> { }


