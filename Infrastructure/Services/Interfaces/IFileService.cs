using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeeBox.Infrastructure.Services.Interfaces
{
    public interface IFileService
    {
        public enum FileType
        {
            Original,
            Svg
        }

        Task<FileInfo> SaveFileAsync(IBrowserFile file, FileType fileType);
    }
}
