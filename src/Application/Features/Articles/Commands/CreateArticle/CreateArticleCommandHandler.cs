using Application.Repositories.Articles;
using Application.Services;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Articles.Commands.CreateArticle;

public class CreateArticleCommandHandler : IRequestHandler<CreateArticleCommandRequest, CreateArticleCommandResponse>
{
    private readonly IArticleCommandRepository _articleCommandRepository;
    private readonly IMapper _mapper;
    private readonly IArticleHubService _articleHubService;

    public CreateArticleCommandHandler(IArticleCommandRepository articleCommandRepository, IMapper mapper, IArticleHubService articleHubService)
    {
        _articleCommandRepository = articleCommandRepository;
        _mapper = mapper;
        _articleHubService = articleHubService;
    }

    public async Task<CreateArticleCommandResponse> Handle(CreateArticleCommandRequest request, CancellationToken cancellationToken)
    {
        var article = _mapper.Map<Article>(request);
        var added = await _articleCommandRepository.AddAsync(article);
        var mapped = _mapper.Map<CreateArticleCommandResponse>(added);
        await _articleHubService.ArticleAddedMessageAsync("Ekleme işlemi başarılı.");
        return mapped;
    }
}


