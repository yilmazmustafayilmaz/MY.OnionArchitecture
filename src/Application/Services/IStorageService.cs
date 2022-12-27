using Application.Abstract.Storages;

namespace Application.Abstract.Services;

public interface IStorageService : IStorage
{
    string StorageName { get; }
}

