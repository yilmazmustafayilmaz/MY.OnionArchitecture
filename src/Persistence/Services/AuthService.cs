using Application.Exceptions;
using Application.Services;
using Domain.Dtos;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services;

public class AuthService : IAuthService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly ITokenHandlerService _tokenHandlerService;
    private readonly IUserService _userService;

    public AuthService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ITokenHandlerService tokenHandlerService, IUserService userService)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _tokenHandlerService = tokenHandlerService;
        _userService = userService;
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

    public async Task<TokenDto> RefreshTokenLoginAsync(string refreshToken)
    {
        var user = await _userManager.Users.FirstOrDefaultAsync(x => x.RefreshToken == refreshToken);
        if (user != null && user?.RefreshTokenEndDate > DateTime.UtcNow)
        {
            var token = _tokenHandlerService.CreateAccessToken(15);
            await _userService.InsertRefreshToken(token.RefreshToken, user, token.Expiration, 15);
            return token;
        }
        else
            throw new NotFoundUserException();
    }
}


