using MediatR;

namespace Application.Features.Authors.Commands.CreateAuthor;

public record CreateAuthorCommandRequest : IRequest<CreateAuthorCommandResponse>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}

