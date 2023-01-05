using Domain.Dtos;
using Domain.Entities;

namespace Application.Services;

public interface IUserService
{
    Task<CreateUserResponseDto> CreateAsync(CreateUserDto createUserDto);
    Task InsertRefreshToken(string refreshToken, AppUser user, DateTime addOnAccessTokenDate, int refreshTokenLifeTime);
}


