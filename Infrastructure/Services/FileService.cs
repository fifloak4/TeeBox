using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Threading.Tasks;
using TeeBox.Infrastructure.Services.Interfaces;
using TeeBox.Infrastructure.Services.Options;
using static TeeBox.Infrastructure.Services.Interfaces.IFileService;

namespace TeeBox.Infrastructure.Services
{
    public class FileService : IFileService
    {
        private readonly FileServiceOptions _fileServiceOptions;

        public FileService(IOptions<FileServiceOptions> fileServiceOptions)
        {
            _fileServiceOptions = fileServiceOptions.Value;
            CheckDirectories();
        }

        public async Task<FileInfo> SaveFileAsync(IBrowserFile file, FileType fileType)
        {
            var path = Path.Combine(_fileServiceOptions.BasePath,
                fileType switch
                {
                    FileType.Original => _fileServiceOptions.OriginalPath,
                    FileType.Svg => _fileServiceOptions.SvgPath,
                    _ => throw new NotSupportedException($"FileType: {fileType} is not supported in current version.")
                },
                Guid.NewGuid().ToString());

            await using FileStream fs =
                new(path,
                FileMode.Create);

            await file.OpenReadStream().CopyToAsync(fs);

            return new FileInfo(path);
        }

        private void CheckDirectories()
        {
            Directory.CreateDirectory(Path.Combine(_fileServiceOptions.BasePath, _fileServiceOptions.OriginalPath));
            Directory.CreateDirectory(Path.Combine(_fileServiceOptions.BasePath, _fileServiceOptions.SvgPath));
        }
    }
}
