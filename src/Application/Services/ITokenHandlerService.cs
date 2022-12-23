using Application.Dtos;

namespace Application.Services;

public interface ITokenHandlerService
{
    TokenDto CreateAccessToken(int minute);
}


