using Application.Repositories.Authors;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Authors.Commands.CreateAuthor;

public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommandRequest, CreateAuthorCommandResponse>
{
    private readonly IAuthorCommandRepository _authorCommandRepository;
    private readonly IMapper _mapper;

    public CreateAuthorCommandHandler(IAuthorCommandRepository authorCommandRepository, IMapper mapper)
    {
        _authorCommandRepository = authorCommandRepository;
        _mapper = mapper;
    }

    public async Task<CreateAuthorCommandResponse> Handle(CreateAuthorCommandRequest request, CancellationToken cancellationToken)
    {
        var author = _mapper.Map<Author>(request);
        var added = await _authorCommandRepository.AddAsync(author);
        var mapped = _mapper.Map<CreateAuthorCommandResponse>(added);
        return mapped;
    }
}

