using Domain.Dtos;

namespace Application.Services;

public interface IUserService
{
    Task<CreateUserResponseDto> CreateAsync(CreateUserDto createUserDto);
}


