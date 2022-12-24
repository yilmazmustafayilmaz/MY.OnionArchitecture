using Application.Dtos;
using Microsoft.AspNetCore.Http;

namespace Application.Storages;

public interface IStorage
{
    Task<List<UploadDto>> UploadAsync(IFormFileCollection files, string path);
    Task DeleteAsync(string path);
}


