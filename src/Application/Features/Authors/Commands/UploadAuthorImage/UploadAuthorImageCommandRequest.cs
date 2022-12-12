using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.Features.Authors.Commands.CreateAuthorImage;

public record UploadAuthorImageCommandRequest : IRequest
{
    public Guid AuthorId { get; set; }
    public IFormFileCollection Files { get; set; }
}
