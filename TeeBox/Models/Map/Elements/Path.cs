using System.Xml;

namespace TeeBox.Application.Models.Map
{
    public class Path : Element
    {
        public Path(XmlElement node, bool keepStyle = false) : base(node, keepStyle)
        {
            Definition = node.Attributes["d"].Value;
        }

        public string Definition { get; set; }
#nullable enable
        public override XmlElement GetXml(XmlDocument document, string? label = null)
#nullable disable
        {
            var elem = document.CreateElement("path");
            base.AddAttributes(elem);
            elem.SetAttribute("d", Definition);
            return elem;
        }
    }
}
