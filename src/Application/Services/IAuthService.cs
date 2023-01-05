using Domain.Dtos;

namespace Application.Services;

public interface IAuthService
{
    Task<TokenDto> LoginAsync(string usernameOrEmail, string password, int accessTokenLifeTime);
    Task<TokenDto> RefreshTokenLoginAsync(string refreshToken);
}


