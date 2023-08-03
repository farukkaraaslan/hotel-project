using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace HotelProject.Core.Helpers.FileHelper;

public interface IFileHelper
{
    string AddFile(IFormFile file, string rootPath);
    string UpdateFile(IFormFile file, string filePath, string rootPath);
    void DeleteFile(string filePath);
}
