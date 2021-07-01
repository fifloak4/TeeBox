using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TeeBox.Application.Models.Map.Interfaces;

namespace TeeBox.Application.Models.Map
{
    public class Circle : Element
    {
        public Circle(XmlElement node, bool keepStyle = false) : base(node, keepStyle)
        {
            Cx = double.Parse(node.Attributes["cx"].Value);
            Cy = double.Parse(node.Attributes["cy"].Value);
            R = double.Parse(node.Attributes["r"].Value);

        }
        public double Cx { get; set; }
        public double Cy { get; set; }
        public double R { get; set; }

#nullable enable
        public override XmlElement GetXml(XmlDocument root, string? label = null)
        {
            var elem = root.CreateElement("circle");
            base.AddAttributes(elem);
            elem.SetAttribute("cx", Cx.ToString());
            elem.SetAttribute("cy", Cy.ToString());
            elem.SetAttribute("r", R.ToString());
            return elem;
        }
#nullable disable
    }
}
