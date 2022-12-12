using Application.Constants;
using Application.Repositories.AuthorImagesFiles;
using Application.Repositories.Authors;
using Application.Services;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Authors.Commands.CreateAuthorImage;

public class UploadAuthorImageCommandHandler : IRequestHandler<UploadAuthorImageCommandRequest>
{
    private readonly IStorageService _storageService;
    private readonly IAuthorImageFileCommandRepository _authorImageFileCommandRepository;
    private readonly IAuthorQueryRepository _authorQueryRepository;
    private readonly IMapper _mapper;

    public UploadAuthorImageCommandHandler(IStorageService storageService, IAuthorImageFileCommandRepository authorImageFileCommandRepository, IAuthorQueryRepository authorQueryRepository, IMapper mapper)
    {
        _storageService = storageService;
        _authorImageFileCommandRepository = authorImageFileCommandRepository;
        _authorQueryRepository = authorQueryRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UploadAuthorImageCommandRequest request, CancellationToken cancellationToken)
    {
        List<(string fileName, string path)> result = await _storageService.UploadAsync(request.Files, FilePath.ImagePath);

        Author author = await _authorQueryRepository.GetByIdAsync(request.AuthorId.ToString());

        await _authorImageFileCommandRepository.AddRangeAsync(result.Select(x => new AuthorImageFile
        {
            FileName = x.fileName,
            Path = x.path,
            Storage = _storageService.StorageName,
            Author = author
        }).ToList());

        return Unit.Value;
    }
}
