using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TeeBox.Application.Models.Map.Interfaces;

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
        public override XmlElement GetXml(XmlDocument root, string? label = null)
#nullable disable
        {
            var elem = root.CreateElement("path");
            base.AddAttributes(elem);
            elem.SetAttribute("d", Definition);
            return elem;
        }
    }
}
