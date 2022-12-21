using Application.Features.Users.Commands.CreateUser;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Application.Features.Users.Mapping;

public class UserProfile : Profile
{
    public UserProfile()
    {
        //Create Mapping
        CreateMap<CreateUserCommandRequest, AppUser>().ReverseMap();
        CreateMap<IdentityResult, CreateUserCommandResponse>().ReverseMap();
    }
}


