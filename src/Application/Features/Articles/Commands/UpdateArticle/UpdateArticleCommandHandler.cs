using Application.Repositories.Articles;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Articles.Commands.UpdateArticle;

public class UpdateArticleCommandHandler : IRequestHandler<UpdateArticleCommandRequest, UpdateArticleCommandResponse>
{
    private readonly IArticleCommandRepository _articleCommandRepository;
    private readonly IArticleQueryRepository _articleQueryRepository;
    private readonly IMapper _mapper;

    public UpdateArticleCommandHandler(IArticleCommandRepository articleCommandRepository, IMapper mapper, IArticleQueryRepository articleQueryRepository)
    {
        _articleCommandRepository = articleCommandRepository;
        _mapper = mapper;
        _articleQueryRepository = articleQueryRepository;
    }

    public async Task<UpdateArticleCommandResponse> Handle(UpdateArticleCommandRequest request, CancellationToken cancellationToken)
    {
        var article = await _articleQueryRepository.GetByIdAsync(request.Id.ToString());
        article.AuthorId = request.AuthorId;
        article.Title = request.Title;
        article.Description = request.Description;

        var updated = await _articleCommandRepository.UpdateAsync(article);
        var mapped = _mapper.Map<UpdateArticleCommandResponse>(updated);
        return mapped;    
    }
}

