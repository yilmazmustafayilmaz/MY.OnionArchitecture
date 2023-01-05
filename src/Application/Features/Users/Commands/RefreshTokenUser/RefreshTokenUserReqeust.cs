using MediatR;

namespace Application.Features.Users.Commands.RefreshTokenUser;

public record RefreshTokenUserReqeust : IRequest<RefreshTokenUserResponse>
{
    public string RefreshToken { get; set; }
}


