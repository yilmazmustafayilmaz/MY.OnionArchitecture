using Application.Services;
using AutoMapper;
using MediatR;

namespace Application.Features.Users.Commands.LoginUser;

public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>
{
    private readonly IAuthService _authService;
    private readonly IMapper _mapper;

    public LoginUserCommandHandler(IAuthService authService, IMapper mapper)
    {
        _authService = authService;
        _mapper = mapper;
    }

    public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
    {
        var token = await _authService.LoginAsync(request.UsernameOrEmail, request.Password, 15);
        var mapped = _mapper.Map<LoginUserCommandResponse>(token);
        return mapped;
    }
}

