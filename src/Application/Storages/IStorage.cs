using Microsoft.AspNetCore.Http;

namespace Application.Storages;

public interface IStorage
{
    Task<List<(string fileName, string path)>> UploadAsync(IFormFileCollection files, string path);
    Task DeleteAsync(string path);
}


