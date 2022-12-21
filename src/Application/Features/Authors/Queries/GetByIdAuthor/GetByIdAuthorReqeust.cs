using MediatR;

namespace Application.Features.Authors.Queries.GetByIdAuthor;

public record GetByIdAuthorQueryReqeust(Guid Id) : IRequest<GetByIdAuthorQueryResponse> { }


