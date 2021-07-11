using TeeBox.Application.Models.Map;

namespace TeeBox.Application.Services.Interfaces
{
    public interface IMapService
    {
        string GenerateSvg(Map map);
        Map ImportMap(string path);
    }
}
