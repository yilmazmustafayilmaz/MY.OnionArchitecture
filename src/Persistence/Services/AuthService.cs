using Application.Exceptions;
using Application.Services;
using Domain.Dtos;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Persistence.Services;

public class AuthService : IAuthService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly ITokenHandlerService _tokenHandlerService;

    public AuthService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ITokenHandlerService tokenHandlerService)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _tokenHandlerService = tokenHandlerService;
    }
    public async Task<TokenDto> LoginAsync(string usernameOrEmail, string password, int accessTokenLifeTime)
    {
        var user = await _userManager.FindByNameAsync(usernameOrEmail);
        if (user is null) user = await _userManager.FindByEmailAsync(usernameOrEmail);

        if (user is null) throw new NotFoundUserException();

        var result = await _signInManager.CheckPasswordSignInAsync(user, password, false);

        if (result.Succeeded)
        {
            TokenDto token = _tokenHandlerService.CreateAccessToken(accessTokenLifeTime);
            return token;
        }
        throw new AuthenticationException();
    }
}


