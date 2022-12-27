using Application.Abstract.Paginate;
using MediatR;

namespace Application.Features.Articles.Queries.GetAllArticle;

public record GetAllArticleQueryRequest(Pagination pagination) : IRequest<List<GetAllArticleQueryResponse>> { }


