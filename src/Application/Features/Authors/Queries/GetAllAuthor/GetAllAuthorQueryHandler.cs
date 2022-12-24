using Application.Repositories.Authors;
using Application.Services;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Authors.Queries.GetAllAuthor;

public class GetAllAuthorQueryHandler : IRequestHandler<GetAllAuthorQueryRequest, List<GetAllAuthorQueryResponse>>
{
    private readonly IAuthorQueryRepository _authorQueryRepository;
    private readonly IMapper _mapper;
    private readonly IPaginationService<Author> _paginationService;

    public GetAllAuthorQueryHandler(IAuthorQueryRepository authorQueryRepository, IMapper mapper, IPaginationService<Author> paginationService)
    {
        _authorQueryRepository = authorQueryRepository;
        _mapper = mapper;
        _paginationService = paginationService;
    }

    public async Task<List<GetAllAuthorQueryResponse>> Handle(GetAllAuthorQueryRequest request, CancellationToken cancellationToken)
    {
        var authors = _authorQueryRepository.GetAll(null, false);
        var pagination = _paginationService.QueryablePagination(authors, request.pagination);

        var mapped = _mapper.Map<List<GetAllAuthorQueryResponse>>(authors);
        return mapped;
    }
}