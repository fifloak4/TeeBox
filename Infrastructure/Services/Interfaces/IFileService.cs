using Microsoft.AspNetCore.Components.Forms;
using System.IO;
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
