using Application.Paginate;
using MediatR;

namespace Application.Features.Authors.Queries.GetAllAuthor;

public record GetAllAuthorQueryRequest(Pagination pagination) : IRequest<List<GetAllAuthorQueryResponse>> { }
