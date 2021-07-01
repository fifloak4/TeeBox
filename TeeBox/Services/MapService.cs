using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TeeBox.Application.Services.Interfaces;
using TeeBox.Application.Models.Map;
using System.IO;

namespace TeeBox.Application.Services
{
    public class MapService : IMapService
    {

        //Public
        public Map ImportMap(string path)
        {
            var doc = OpenFile(path);

            var map = ProcessMap(doc);

            return map;
        }

        public string GenerateSvg(Map map)
        {
            XmlDocument doc = new();
            XmlElement root = doc.CreateElement("svg");

            root.SetAttribute("viewBox", $"0 0 {Convert.ToInt32(map.Width) + 1} {Convert.ToInt32(map.Height) + 1}");

            var green = map.Green?.GetXml(doc) ?? null;
            var rocks = map.Rocks?.GetXml(doc) ?? null;
            var trees = map.Trees?.GetXml(doc) ?? null;
            var paths = map.Paths?.GetXml(doc) ?? null;
            var water = map.Water?.GetXml(doc) ?? null;
            var teeMarkers = map.TeeMarkers?.GetXml(doc) ?? null;
            var tees = map.Tees?.GetXml(doc) ?? null;
            var pin = map.Pin?.GetXml(doc) ?? null;
            var roughOverlay = map.RoughOverlay?.GetXml(doc) ?? null;
            var bunkers = map.Bunkers?.GetXml(doc) ?? null;
            var fairways = map.Fairways?.GetXml(doc) ?? null;
            var wasteland = map.Wasteland?.GetXml(doc) ?? null;
            var rough = map.Rough?.GetXml(doc) ?? null;

            if (rough != null)
                root.AppendChild(rough);

            if (wasteland != null)
                root.AppendChild(wasteland);

            if (fairways != null)
                root.AppendChild(fairways);

            if (green != null)
                root.AppendChild(green);

            if (bunkers != null)
                root.AppendChild(bunkers);

            if (roughOverlay != null)
                root.AppendChild(roughOverlay);

            if (pin != null)
                root.AppendChild(pin);

            if (tees != null)
                root.AppendChild(tees);

            if (teeMarkers != null)
                root.AppendChild(teeMarkers);

            if (water != null)
                root.AppendChild(water);

            if (paths != null)
                root.AppendChild(paths);

            if (trees != null)
                root.AppendChild(trees);

            if (rocks != null)
                root.AppendChild(rocks);

            doc.AppendChild(root);

            using var stringWriter = new StringWriter();
            using var xmlTextWriter = XmlWriter.Create(stringWriter);
            doc.WriteTo(xmlTextWriter);
            xmlTextWriter.Flush();
            return stringWriter.GetStringBuilder().ToString();
        }

        //Private
        private static XmlDocument OpenFile(string path)
        {
            XmlDocument document = new();
            document.Load(path);
            return document;
        }

        private static Map ProcessMap(XmlDocument document, string laverAttributeName = "inkscape:label")
        {
            //var map = new Map(document, laverAttributeName);
            Map map = new();

            SetWidthHeight(document, map);

            ProcessLayers(document, map, laverAttributeName);

            return map;
        }

        private static void ProcessLayers(XmlDocument document, Map map, string laverAttributeName)
        {
            map.Green = GetLayer(document, laverAttributeName, "green");
            map.Rocks = GetLayer(document, laverAttributeName, "rocks");
            map.Trees = GetLayer(document, laverAttributeName, "trees");
            map.Paths = GetLayer(document, laverAttributeName, "path");
            map.Water = GetLayer(document, laverAttributeName, "water");
            map.TeeMarkers = GetLayer(document, laverAttributeName, "tee-marker", true);
            map.Tees = GetLayer(document, laverAttributeName, "tee");
            map.Pin = GetLayer(document, laverAttributeName, "pin");
            map.RoughOverlay = GetLayer(document, laverAttributeName, "rough-overlay");
            map.Bunkers = GetLayer(document, laverAttributeName, "bunker");
            map.Fairways = GetLayer(document, laverAttributeName, "fairway");
            map.Wasteland = GetLayer(document, laverAttributeName, "wasteland");
            map.Rough = GetLayer(document, laverAttributeName, "rough");
        }

        private static Layer GetLayer(XmlDocument document, string attribute, string value, bool keepStyle = false)
        {
            var root = document
                .DocumentElement;

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

        private static void SetWidthHeight(XmlDocument document, Map map)
        {
            var root = document
                .DocumentElement;

            map.Width = root
                .GetAttribute("width")
                .RemoveUnits();

            map.Height = root
                .GetAttribute("height")
                .RemoveUnits();
        }

    }
}
