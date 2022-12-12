using Application.Repositories.Authors;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Authors.Commands.RemoveAuthor;

public class RemoveAuthorCommandHandler : IRequestHandler<RemoveAuthorCommandReqeust, RemoveAuthorCommandResponse>
{
    private readonly IAuthorCommandRepository _authorCommandRepository;
    private readonly IMapper _mapper;

    public RemoveAuthorCommandHandler(IAuthorCommandRepository authorCommandRepository, IMapper mapper)
    {
        _authorCommandRepository = authorCommandRepository;
        _mapper = mapper;
    }

    public async Task<RemoveAuthorCommandResponse> Handle(RemoveAuthorCommandReqeust request, CancellationToken cancellationToken)
    {
        var author = _mapper.Map<Author>(request);
        var deleted = await _authorCommandRepository.RemoveAsync(author);
        var mapped = _mapper.Map<RemoveAuthorCommandResponse>(deleted);
        return mapped;
    }
}


