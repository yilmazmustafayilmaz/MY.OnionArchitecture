using Application.Repositories.Articles;
using AutoMapper;
using MediatR;

namespace Application.Features.Articles.Queries.GetByIdArticle;

public class GetByIdArticleQueryHandler : IRequestHandler<GetByIdArticleQueryRequest, GetByIdArticleQueryResponse>
{
    private readonly IArticleQueryRepository _articleQueryRepository;
    private readonly IMapper _mapper;

    public GetByIdArticleQueryHandler(IArticleQueryRepository articleQueryRepository, IMapper mapper)
    {
        _articleQueryRepository = articleQueryRepository;
        _mapper = mapper;
    }

    public async Task<GetByIdArticleQueryResponse> Handle(GetByIdArticleQueryRequest request, CancellationToken cancellationToken)
    {
        var article = await _articleQueryRepository.GetByIdAsync(request.Id.ToString(), false);
        var mapped = _mapper.Map<GetByIdArticleQueryResponse>(article);
        return mapped;
    }
}



