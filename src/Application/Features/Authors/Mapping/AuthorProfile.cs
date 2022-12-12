using Application.Features.Authors.Commands.CreateAuthor;
using Application.Features.Authors.Commands.CreateAuthorImage;
using Application.Features.Authors.Commands.RemoveAuthor;
using Application.Features.Authors.Commands.UpdateAuthor;
using Application.Features.Authors.Queries.GetAllAuthor;
using Application.Features.Authors.Queries.GetByIdAuthor;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Authors.Mapping;

public class AuthorProfile : Profile
{
    public AuthorProfile()
    {
        //Create Mapping
        CreateMap<CreateAuthorCommandRequest, Author>().ReverseMap();
        CreateMap<Author, CreateAuthorCommandResponse>().ReverseMap();
        //Update Mapping
        CreateMap<UpdateAuthorCommandRequest, Author>().ReverseMap();
        CreateMap<Author, UpdateAuthorCommandResponse>().ReverseMap();
        //Remove Mapping
        CreateMap<RemoveAuthorCommandReqeust, Author>().ReverseMap();
        CreateMap<Author, RemoveAuthorCommandResponse>().ReverseMap();
        //GetAll Mapping
        CreateMap<Author, GetAllAuthorQueryResponse>().ReverseMap();
        //GetById Mapping
        CreateMap<Author, GetByIdAuthorQueryResponse>().ReverseMap();
        //Upload Mapping
        CreateMap<AuthorImageFile, UploadAuthorImageCommandRequest>().ReverseMap();
    }
}


