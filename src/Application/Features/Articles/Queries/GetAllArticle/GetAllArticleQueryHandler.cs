using Application.Repositories.Articles;
using Application.Services;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Articles.Queries.GetAllArticle;

public class GetAllArticleQueryHandler : IRequestHandler<GetAllArticleQueryRequest, List<GetAllArticleQueryResponse>>
{
    private readonly IArticleQueryRepository _articleQueryRepository;
    private readonly IMapper _mapper;
    private readonly IPaginationService<Article> _paginationService;

    public GetAllArticleQueryHandler(IArticleQueryRepository articleQueryRepository, IMapper mapper, IPaginationService<Article> paginationService)
    {
        _articleQueryRepository = articleQueryRepository;
        _mapper = mapper;
        _paginationService = paginationService;
    }

    public async Task<List<GetAllArticleQueryResponse>> Handle(GetAllArticleQueryRequest request, CancellationToken cancellationToken)
    {
        var articles = _articleQueryRepository.GetAll(null, false);
        var pagination = _paginationService.QueryablePagination(articles, request.pagination);

        var mapped = _mapper.Map<List<GetAllArticleQueryResponse>>(pagination);
        return mapped;
    }
}



