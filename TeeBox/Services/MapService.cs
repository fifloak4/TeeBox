using System.Linq;
using System.Xml;
using TeeBox.Application.Models.Map;
using TeeBox.Application.Services.Interfaces;

namespace TeeBox.Application.Services
{
    public class MapService : IMapService
    {
        public Map ImportMap(string path)
        {
            var doc = OpenFile(path);

            var map = ProcessMap(doc);

            return map;
        }

        public string GenerateSvg(Map map)
        {
            var svg = map.GenerateSvg();
            return svg;
        }

        private static XmlDocument OpenFile(string path)
        {
            XmlDocument document = new();
            document.Load(path);
            return document;
        }

        private static Map ProcessMap(XmlDocument document, string laverAttributeName = "inkscape:label")
        {
            Map map = new();

            var root = document
                .DocumentElement;

            SetWidthHeight(root, map);

            ProcessLayers(root, map, laverAttributeName);

            return map;
        }

        private static void ProcessLayers(XmlElement root, Map map, string laverAttributeName)
        {
            map.Green = GetLayer(root, laverAttributeName, "green");
            map.Rocks = GetLayer(root, laverAttributeName, "rocks");
            map.Trees = GetLayer(root, laverAttributeName, "trees");
            map.Paths = GetLayer(root, laverAttributeName, "path");
            map.Water = GetLayer(root, laverAttributeName, "water");
            map.TeeMarkers = GetLayer(root, laverAttributeName, "tee-marker", true);
            map.Tees = GetLayer(root, laverAttributeName, "tee");
            map.Pin = GetLayer(root, laverAttributeName, "pin");
            map.RoughOverlay = GetLayer(root, laverAttributeName, "rough-overlay");
            map.Bunkers = GetLayer(root, laverAttributeName, "bunker");
            map.Fairways = GetLayer(root, laverAttributeName, "fairway");
            map.Wasteland = GetLayer(root, laverAttributeName, "wasteland");
            map.Rough = GetLayer(root, laverAttributeName, "rough");
        }

        private static Layer GetLayer(XmlElement root, string attribute, string value, bool keepStyle = false)
        {
            var element = root
                .ChildNodes
                .OfType<XmlElement>()
                .Where(node =>
                    node.HasAttribute(attribute) &&
                    node.Attributes[attribute].Value == value)
                .SingleOrDefault();

            if (element != null)
                if (element.ChildNodes.Count != 0)
                {
                    var layer = new Layer(element, keepStyle)
                    {
                        Class = value
                    };
                    return layer;
                }
            return null;
        }

        private static void SetWidthHeight(XmlElement root, Map map)
        {
            map.Width = root
                .GetAttribute("width")
                .RemoveUnits();

            map.Height = root
                .GetAttribute("height")
                .RemoveUnits();
        }

    }
}
