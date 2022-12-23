using MediatR;

namespace Application.Features.Users.Commands.LoginUser;

public record LoginUserCommandRequest : IRequest<LoginUserCommandResponse>
{
    public string UsernameOrEmail { get; set; }
    public string Password { get; set; }
}

