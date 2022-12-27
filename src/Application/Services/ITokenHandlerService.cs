using Domain.Dtos;

namespace Application.Services;

public interface ITokenHandlerService
{
    TokenDto CreateAccessToken(int minute);
}


