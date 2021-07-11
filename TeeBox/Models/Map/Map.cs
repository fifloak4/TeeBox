using System;
using System.IO;
using System.Xml;

namespace TeeBox.Application.Models.Map
{
    public class Map
    {
        public Layer Green { get; set; }

        public Layer Pin { get; set; }

        public Layer Fairways { get; set; }

        public Layer Bunkers { get; set; }

        public Layer Water { get; set; }

        public Layer Tees { get; set; }

        public Layer TeeMarkers { get; set; }

        public Layer Paths { get; set; }

        public Layer Wasteland { get; set; }

        public Layer Trees { get; set; }

        public Layer Rough { get; set; }

        public Layer RoughOverlay { get; set; }

        public Layer Rocks { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public string GenerateSvg()
        {
            XmlDocument doc = new();
            XmlElement root = CreateRoot(doc);
            SetRootAttributes(root);

            AddLayer(Rough, root, doc);
            AddLayer(Wasteland, root, doc);
            AddLayer(Fairways, root, doc);
            AddLayer(Green, root, doc);
            AddLayer(Bunkers, root, doc);
            AddLayer(RoughOverlay, root, doc);
            AddLayer(Pin, root, doc);
            AddLayer(Tees, root, doc);
            AddLayer(TeeMarkers, root, doc);
            AddLayer(Water, root, doc);
            AddLayer(Paths, root, doc);
            AddLayer(Trees, root, doc);
            AddLayer(Rocks, root, doc);

            AddRoot(doc, root);

            return XmlToString(doc);
        }

        private static string XmlToString(XmlDocument doc)
        {
            using var stringWriter = new StringWriter();
            using var xmlTextWriter = XmlWriter.Create(stringWriter);
            doc.WriteTo(xmlTextWriter);
            xmlTextWriter.Flush();
            return stringWriter.GetStringBuilder().ToString();
        }

        private static void AddRoot(XmlDocument doc, XmlElement root)
        {
            doc.AppendChild(root);
        }

        private void SetRootAttributes(XmlElement root)
        {
            root.SetAttribute("viewBox", $"0 0 {Convert.ToInt32(Width) + 1} {Convert.ToInt32(Height) + 1}");
        }

        private static XmlElement CreateRoot(XmlDocument doc)
        {
            return doc.CreateElement("svg");
        }

        private static void AddLayer(Layer layer, XmlElement root, XmlDocument document)
        {
            var green = layer?.GetXml(document) ?? null;
            if (green != null)
                root.AppendChild(green);
        }
    }
}
