using Application.Features.Users.Commands.CreateUser;
using Application.Features.Users.Commands.LoginUser;
using AutoMapper;
using Domain.Dtos;

namespace Application.Features.Users.Mapping;

public class UserProfile : Profile
{
    public UserProfile()
    {
        //Create Mapping
        CreateMap<CreateUserCommandRequest, CreateUserDto>().ReverseMap();
        CreateMap<CreateUserResponseDto, CreateUserCommandResponse>().ReverseMap();
        //Login
        CreateMap<LoginUserCommandResponse, TokenDto>()
            .ForMember(des => des.AccessToken, opt => opt
            .MapFrom(src => src.Token.AccessToken)).ReverseMap();
    }
}


