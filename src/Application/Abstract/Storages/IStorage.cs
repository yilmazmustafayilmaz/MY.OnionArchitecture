using Domain.Dtos;
using Microsoft.AspNetCore.Http;

namespace Application.Abstract.Storages;

public interface IStorage
{
    Task<List<UploadDto>> UploadAsync(IFormFileCollection files, string path);
    Task DeleteAsync(string path);
}


