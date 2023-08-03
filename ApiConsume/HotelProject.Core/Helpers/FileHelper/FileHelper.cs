using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HotelProject.Core.Helpers.FileHelper;

public class FileHelper : IFileHelper
{
    public string AddFile(IFormFile file, string rootPath)
    {
        CreateRootDirectoryIfNotExists(rootPath);

        var imageExtension = Path.GetExtension(file.FileName);

        var imageName = Guid.NewGuid().ToString() + imageExtension;

        var filePath = Path.Combine(rootPath, imageName);

        using (var fileStream = new FileStream(filePath, FileMode.Create))
        {
            file.CopyTo(fileStream);
        }

        return imageName;
    }

    public void DeleteFile(string filePath)
    {

        var fullPath = Path.Combine("wwwroot/"+filePath);
        if (File.Exists(fullPath))
        {
            File.Delete(fullPath);
        }
    }

    public string UpdateFile(IFormFile file, string filePath, string rootPath)
    {
        Console.WriteLine(filePath);

        DeleteFile(filePath);
        return AddFile(file, rootPath);
    }
    private void CreateRootDirectoryIfNotExists(string rootPath)
    {
        if (!Directory.Exists(rootPath))
        {
            Directory.CreateDirectory(rootPath);
        }
    }
}
