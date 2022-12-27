using Application.Abstract.Services;
using Application.Abstract.Storages;
using Domain.Dtos;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Services;

public class StorageService : IStorageService
{
    private readonly IStorage _storage;

    public StorageService(IStorage storage) => _storage = storage;

    public string StorageName => _storage.GetType().Name;

    public Task DeleteAsync(string path) => _storage.DeleteAsync(path);

    public Task<List<UploadDto>> UploadAsync(IFormFileCollection files, string path) => _storage.UploadAsync(files, path);
}


