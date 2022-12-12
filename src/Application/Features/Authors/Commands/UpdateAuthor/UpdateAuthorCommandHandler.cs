using Application.Repositories.Authors;
using AutoMapper;
using MediatR;

namespace Application.Features.Authors.Commands.UpdateAuthor;

public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommandRequest, UpdateAuthorCommandResponse>
{
    private readonly IAuthorCommandRepository _authorCommandRepository;
    private readonly IAuthorQueryRepository _authorQueryRepository;
    private readonly IMapper _mapper;

    public UpdateAuthorCommandHandler(IAuthorCommandRepository authorCommandRepository, IMapper mapper, IAuthorQueryRepository authorQueryRepository)
    {
        _authorCommandRepository = authorCommandRepository;
        _mapper = mapper;
        _authorQueryRepository = authorQueryRepository;
    }
    public async Task<UpdateAuthorCommandResponse> Handle(UpdateAuthorCommandRequest request, CancellationToken cancellationToken)
    {
        var author = await _authorQueryRepository.GetByIdAsync(request.Id.ToString());
        author.Name = request.Name;
        author.Surname = request.Surname;
        author.Age = request.Age;

        var updated = await _authorCommandRepository.UpdateAsync(author);
        var mapped = _mapper.Map<UpdateAuthorCommandResponse>(updated);
        return mapped;
    }
}


