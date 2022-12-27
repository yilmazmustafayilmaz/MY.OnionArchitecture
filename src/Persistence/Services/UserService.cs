using Application.Services;
using Domain.Dtos;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Persistence.Services;

public class UserService : IUserService
{
    private readonly UserManager<AppUser> _userManager;

    public UserService(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<CreateUserResponseDto> CreateAsync(CreateUserDto createUserDto)
    {
        IdentityResult result = await _userManager.CreateAsync(new()
        {
            Id = Guid.NewGuid(),
            UserName = createUserDto.Username,
            Email = createUserDto.Email,
            Name = createUserDto.Name,
            Surname = createUserDto.Surname
        }, createUserDto.Password);

        CreateUserResponseDto response = new() { Succes = result.Succeeded };

        if (result.Succeeded)
            response.Message = "Kullan�c� ba�ar�yla olu�turulmu�tur";
        else
            foreach (var error in result.Errors)
                response.Message += $"{error.Code} - {error.Description}";

        return response;
    }
}
