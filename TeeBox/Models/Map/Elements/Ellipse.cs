using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TeeBox.Application.Models.Map.Interfaces;

namespace TeeBox.Application.Models.Map
{
    public class Ellipse : Element
    {
        public Ellipse(XmlElement node, bool keepStyle = false) : base(node, keepStyle)
        {
            Cx = double.Parse(node.Attributes["cx"].Value);
            Cy = double.Parse(node.Attributes["cy"].Value);
            Rx = double.Parse(node.Attributes["rx"].Value);
            Ry = double.Parse(node.Attributes["ry"].Value);
        }

        public double Cx { get; set; }
        public double Cy { get; set; }
        public double Rx { get; set; }
        public double Ry { get; set; }
#nullable enable
        public override XmlElement GetXml(XmlDocument document, string? label = null)
#nullable disable
        {
            var elem = document.CreateElement("ellipse");
            base.AddAttributes(elem);
            elem.SetAttribute("cx", Cx.ToString());
            elem.SetAttribute("cy", Cy.ToString());
            elem.SetAttribute("rx", Rx.ToString());
            elem.SetAttribute("ry", Ry.ToString());

            return elem;
        }
    }
}
