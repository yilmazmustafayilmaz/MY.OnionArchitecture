using Application.Dtos;

namespace Application.Features.Users.Commands.LoginUser;

public record LoginUserCommandResponse
{
    public TokenDto Token { get; set; }
}

