using Application.Services;
using Domain.Dtos;
using Domain.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Infrastructure.Services;

public class TokenHandlerService : ITokenHandlerService
{
    private readonly IConfiguration _configuration;

    public TokenHandlerService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public TokenDto CreateAccessToken(int minute, AppUser appUser)
    {
        TokenDto tokenDto = new();
        tokenDto.Expiration = DateTime.UtcNow.AddMinutes(minute);

        SymmetricSecurityKey securityKey = new(Encoding.UTF8.GetBytes(_configuration["Token:SecurityKey"]));

        SigningCredentials signingCredentials = new(securityKey, SecurityAlgorithms.HmacSha512Signature);

        JwtSecurityToken securityToken = new
            (
                audience: _configuration["Token:Audience"],
                issuer: _configuration["Token:Issuer"],
                expires: tokenDto.Expiration,
                notBefore: DateTime.UtcNow,
                signingCredentials: signingCredentials,
                claims: new List<Claim> { new(ClaimTypes.Name, appUser.UserName)}
            );

        JwtSecurityTokenHandler tokenHandler = new();
        tokenDto.AccessToken = tokenHandler.WriteToken(securityToken);
        return tokenDto;
    }
}


