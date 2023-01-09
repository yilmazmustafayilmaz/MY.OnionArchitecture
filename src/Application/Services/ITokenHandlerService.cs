using Domain.Dtos;
using Domain.Entities;

namespace Application.Services;

public interface ITokenHandlerService
{
    TokenDto CreateAccessToken(int minute, AppUser appUser);
}


