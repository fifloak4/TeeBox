using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TeeBox.Application.Models.Map;

namespace TeeBox.Application.Services.Interfaces
{
    public interface IMapService
    {
        string GenerateSvg(Map map);
        Map ImportMap(string path);
    }
}
