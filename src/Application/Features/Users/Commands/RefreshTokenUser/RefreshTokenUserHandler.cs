using Application.Services;
using MediatR;

namespace Application.Features.Users.Commands.RefreshTokenUser;

public class RefreshTokenUserHandler : IRequestHandler<RefreshTokenUserReqeust, RefreshTokenUserResponse>
{
    private readonly IAuthService _authService;

    public RefreshTokenUserHandler(IAuthService authService)
    {
        _authService = authService;
    }

    public async Task<RefreshTokenUserResponse> Handle(RefreshTokenUserReqeust request, CancellationToken cancellationToken)
    {
        var token = await _authService.RefreshTokenLoginAsync(request.RefreshToken);
        return new()
        {
            Token = token
        };
    }
}


