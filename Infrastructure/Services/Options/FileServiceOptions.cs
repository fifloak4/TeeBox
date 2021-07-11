namespace TeeBox.Infrastructure.Services.Options
{
    public class FileServiceOptions
    {
        public const string FileService = "FileService";

        public string OriginalPath { get; set; }
        public string SvgPath { get; set; }
        public string BasePath { get; set; }
    }
}
