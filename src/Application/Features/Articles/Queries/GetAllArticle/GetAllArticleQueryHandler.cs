using Application.Repositories.Articles;
using AutoMapper;
using MediatR;

namespace Application.Features.Articles.Queries.GetAllArticle;

public class GetAllArticleQueryHandler : IRequestHandler<GetAllArticleQueryRequest, List<GetAllArticleQueryResponse>>
{
    private readonly IArticleQueryRepository _articleQueryRepository;
    private readonly IMapper _mapper;

    public GetAllArticleQueryHandler(IArticleQueryRepository articleQueryRepository, IMapper mapper)
    {
        _articleQueryRepository = articleQueryRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllArticleQueryResponse>> Handle(GetAllArticleQueryRequest request, CancellationToken cancellationToken)
    {
        var articles = _articleQueryRepository.GetAll(null, false)
            .Skip(request.pagination.Page * request.pagination.Size)
            .Take(request.pagination.Size).ToList();

        var mapped = _mapper.Map<List<GetAllArticleQueryResponse>>(articles);
        return mapped;
    }
}


