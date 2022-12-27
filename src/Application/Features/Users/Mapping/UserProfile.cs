using Application.Features.Users.Commands.CreateUser;
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
    }
}


