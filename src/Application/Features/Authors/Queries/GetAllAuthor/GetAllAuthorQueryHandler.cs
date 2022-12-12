using Application.Repositories.Authors;
using AutoMapper;
using MediatR;

namespace Application.Features.Authors.Queries.GetAllAuthor;

public class GetAllAuthorQueryHandler : IRequestHandler<GetAllAuthorQueryRequest, List<GetAllAuthorQueryResponse>>
{
    private readonly IAuthorQueryRepository _authorQueryRepository;
    private readonly IMapper _mapper;

    public GetAllAuthorQueryHandler(IAuthorQueryRepository authorQueryRepository, IMapper mapper)
    {
        _authorQueryRepository = authorQueryRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllAuthorQueryResponse>> Handle(GetAllAuthorQueryRequest request, CancellationToken cancellationToken)
    {
        var authors = _authorQueryRepository.GetAll(null, false)
            .Skip(request.pagination.Page * request.pagination.Size)
            .Take(request.pagination.Size).ToList();

        var mapped = _mapper.Map<List<GetAllAuthorQueryResponse>>(authors);
        return mapped;
    }
}