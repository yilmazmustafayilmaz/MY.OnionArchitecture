using Application.Storages;
using Application.Storages.Local;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Storages.Local;

public class LocalStorage : Storage, ILocalStorage
{
    public async Task DeleteAsync(string path)
    {
        if(File.Exists(path)) File.Delete(path);
    }

    public async Task<List<(string fileName, string path)>> UploadAsync(IFormFileCollection files, string path)
    {
        if (!Directory.Exists(path)) Directory.CreateDirectory(path);

        List<(string fileName, string path)> datas = new();
        foreach (var file in files)
        {
            var extension = Path.GetExtension(file.FileName);
            var guid = Guid.NewGuid().ToString();
            var root = guid + extension;
            await CopyFileAsync(file, root, path);
            datas.Add((file.FileName, path + root));
        }
        return datas;
    }

    private async Task<bool> CopyFileAsync(IFormFile file, string root, string path)
    {
        using (FileStream fileStream = File.Create(path + root))
        {
            await file.CopyToAsync(fileStream);
            await fileStream.FlushAsync();
            return true;
        }
    }
}


