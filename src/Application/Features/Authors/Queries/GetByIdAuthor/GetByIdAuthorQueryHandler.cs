using Application.Repositories.Authors;
using AutoMapper;
using MediatR;

namespace Application.Features.Authors.Queries.GetByIdAuthor;

public class GetByIdAuthorQueryHandler : IRequestHandler<GetByIdAuthorQueryReqeust, GetByIdAuthorQueryResponse>
{
    private readonly IAuthorQueryRepository _authorQueryRepository;
    private readonly IMapper _mapper;

    public GetByIdAuthorQueryHandler(IAuthorQueryRepository authorQueryRepository, IMapper mapper)
    {
        _authorQueryRepository = authorQueryRepository;
        _mapper = mapper;
    }
    public async Task<GetByIdAuthorQueryResponse> Handle(GetByIdAuthorQueryReqeust request, CancellationToken cancellationToken)
    {
        var author = await _authorQueryRepository.GetByIdAsync(request.Id.ToString(), false);
        var mapped = _mapper.Map<GetByIdAuthorQueryResponse>(author);
        return mapped;
    }
}


