using Application.Repositories.Articles;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Articles.Commands.CreateArticle;

public class CreateArticleCommandHandler : IRequestHandler<CreateArticleCommandRequest, CreateArticleCommandResponse>
{
    private readonly IArticleCommandRepository _articleCommandRepository;
    private readonly IMapper _mapper;

    public CreateArticleCommandHandler(IArticleCommandRepository articleCommandRepository, IMapper mapper)
    {
        _articleCommandRepository = articleCommandRepository;
        _mapper = mapper;
    }

    public async Task<CreateArticleCommandResponse> Handle(CreateArticleCommandRequest request, CancellationToken cancellationToken)
    {
        var article = _mapper.Map<Article>(request);
        var added = await _articleCommandRepository.AddAsync(article);
        var mapped = _mapper.Map<CreateArticleCommandResponse>(added);
        return mapped;
    }
}


