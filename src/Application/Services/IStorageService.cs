using Application.Storages;

namespace Application.Services;

public interface IStorageService : IStorage
{
    string StorageName { get; }
}

