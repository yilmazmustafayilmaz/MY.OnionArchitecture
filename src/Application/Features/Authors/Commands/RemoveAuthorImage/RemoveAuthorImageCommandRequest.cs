using Application.Repositories.AuthorImagesFiles;
using MediatR;

namespace Application.Features.Authors.Commands.RemoveAuthorImage;

public record RemoveAuthorImageCommandRequest(Guid Id) : IRequest { }

public record RemoveAuthorImageCommandHandler : IRequestHandler<RemoveAuthorImageCommandRequest>
{
    private readonly IAuthorImageFileCommandRepository _authorImageFileCommandRepository;
    private readonly IAuthorImageFileQueryRepository _authorImageFileQueryRepository;

    public RemoveAuthorImageCommandHandler(IAuthorImageFileCommandRepository authorImageFileCommandRepository, IAuthorImageFileQueryRepository authorImageFileQueryRepository)
    {
        _authorImageFileCommandRepository = authorImageFileCommandRepository;
        _authorImageFileQueryRepository = authorImageFileQueryRepository;
    }

    public async Task<Unit> Handle(RemoveAuthorImageCommandRequest request, CancellationToken cancellationToken)
    {
        var authorImage = await _authorImageFileQueryRepository.GetByIdAsync(request.Id.ToString());
        await _authorImageFileCommandRepository.RemoveAsync(authorImage);

        return Unit.Value;
    }
}


