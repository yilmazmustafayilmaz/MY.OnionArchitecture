using MediatR;

namespace Application.Features.Articles.Queries.GetByIdArticle;

public record GetByIdArticleQueryRequest(Guid Id) : IRequest<GetByIdArticleQueryResponse> { }



