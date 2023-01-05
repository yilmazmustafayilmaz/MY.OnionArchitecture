using Domain.Dtos;

namespace Application.Features.Users.Commands.RefreshTokenUser;

public record RefreshTokenUserResponse
{
    public TokenDto Token { get; set; }
}


