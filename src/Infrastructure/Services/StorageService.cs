using Application.Services;
using Application.Storages;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Services;

public class StorageService : IStorageService
{
    private readonly IStorage _storage;

    public StorageService(IStorage storage)
    {
        _storage = storage;
    }

    public string StorageName => _storage.GetType().Name;

    public Task DeleteAsync(string path) => _storage.DeleteAsync(path);

    public Task<List<(string fileName, string path)>> UploadAsync(IFormFileCollection files, string path) => _storage.UploadAsync(files, path);
}


