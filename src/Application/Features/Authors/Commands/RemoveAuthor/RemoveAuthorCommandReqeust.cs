using MediatR;

namespace Application.Features.Authors.Commands.RemoveAuthor;

public record RemoveAuthorCommandReqeust(Guid Id) : IRequest<RemoveAuthorCommandResponse> { }


