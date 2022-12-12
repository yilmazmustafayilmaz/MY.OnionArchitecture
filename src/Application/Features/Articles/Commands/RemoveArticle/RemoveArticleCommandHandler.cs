using Application.Repositories.Articles;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Articles.Commands.RemoveArticle;

public class RemoveArticleCommandHandler : IRequestHandler<RemoveArticleCommandRequest, RemoveArticleCommandResponse>
{
    private readonly IArticleCommandRepository _articleCommandRepository;
    private readonly IMapper _mapper;

    public RemoveArticleCommandHandler(IArticleCommandRepository articleCommandRepository, IMapper mapper)
    {
        _articleCommandRepository = articleCommandRepository;
        _mapper = mapper;
    }

    public async Task<RemoveArticleCommandResponse> Handle(RemoveArticleCommandRequest request, CancellationToken cancellationToken)
    {
        var article = _mapper.Map<Article>(request);
        var deleted = await _articleCommandRepository.RemoveAsync(article);
        var mapped = _mapper.Map<RemoveArticleCommandResponse>(deleted);
        return mapped;
    }
}


