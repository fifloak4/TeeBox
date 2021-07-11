using System.Collections.Generic;
using System.Xml;

namespace TeeBox.Application.Models.Map
{
    public class Layer : Element
    {
        public Layer(XmlElement node, bool keepStyle = false) : base(node, keepStyle)
        {
            var listElements = new List<Element>();
            foreach (XmlElement childElement in node.ChildNodes)
            {
                try
                {
                    listElements.Add(childElement.Name switch
                    {
                        "path" => new Path(childElement, keepStyle),
                        "ellipse" => new Ellipse(childElement, keepStyle),
                        "circle" => new Circle(childElement, keepStyle),
                        _ => null,
                    }
                    );
                }
                catch
                {
                    continue;
                }
                Elements = listElements;
            }
        }
        public IEnumerable<Element> Elements { get; set; }
#nullable enable
        public override XmlElement GetXml(XmlDocument document, string? label = null)
#nullable disable
        {
            var layer = document.CreateElement("g");
            base.AddAttributes(layer);
            foreach (var elem in Elements)
            {
                var xmlElem = elem.GetXml(document);
                layer.AppendChild(xmlElem);
            }
            return layer;
        }
    }
}
