using Application.Features.Articles.Commands.CreateArticle;
using Application.Features.Articles.Commands.RemoveArticle;
using Application.Features.Articles.Commands.UpdateArticle;
using Application.Features.Articles.Queries.GetAllArticle;
using Application.Features.Articles.Queries.GetByIdArticle;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Articles.Mapping;

public class ArticleProfile : Profile
{
    public ArticleProfile()
    {
        //Create Mapping
        CreateMap<CreateArticleCommandRequest, Article>().ReverseMap();
        CreateMap<Article, CreateArticleCommandResponse>().ReverseMap();
        //Update Mapping
        CreateMap<Article, UpdateArticleCommandResponse>().ReverseMap();
        //Remove Mapping
        CreateMap<Article, RemoveArticleCommandRequest>().ReverseMap();
        CreateMap<Article, RemoveArticleCommandResponse>().ReverseMap();
        //GetById Mapping
        CreateMap<Article, GetByIdArticleQueryResponse>().ReverseMap();
        //GetAll Mapping
        CreateMap<Article, GetAllArticleQueryResponse>().ReverseMap();
        //GetById Mapping
        CreateMap<Article, GetByIdArticleQueryResponse>().ReverseMap();
    }
}


