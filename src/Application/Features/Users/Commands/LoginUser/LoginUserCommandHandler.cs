using Application.Exceptions;
using Application.Services;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Application.Features.Users.Commands.LoginUser;

public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly ITokenHandlerService _tokenHandlerService;

    public LoginUserCommandHandler(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ITokenHandlerService tokenHandlerService)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _tokenHandlerService = tokenHandlerService;
    }

    public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByNameAsync(request.UsernameOrEmail);
        if (user is null) user = await _userManager.FindByEmailAsync(request.UsernameOrEmail);

        if (user is null) throw new NotFoundUserException();

        var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

        if (result.Succeeded)
        {
            var token = _tokenHandlerService.CreateAccessToken(5);
            return new LoginUserCommandResponse() { Token = token };
        }
        throw new AuthenticationException();
    }
}

