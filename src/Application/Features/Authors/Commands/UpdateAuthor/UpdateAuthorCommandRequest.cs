using MediatR;

namespace Application.Features.Authors.Commands.UpdateAuthor;

public record UpdateAuthorCommandRequest : IRequest<UpdateAuthorCommandResponse>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}


