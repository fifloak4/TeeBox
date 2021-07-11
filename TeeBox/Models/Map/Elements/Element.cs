using System.Xml;
using TeeBox.Application.Models.Map.Interfaces;

namespace TeeBox.Application.Models.Map
{
    public abstract class Element : IElement
    {
        public Element(XmlElement element, bool keepStyle = false)
        {
            Id = element.Attributes["id"].Value;

            if (element.HasAttribute("style") && keepStyle)
                Style = element.Attributes["style"].Value;

            if (element.HasAttribute("transform"))
                Transform = element.Attributes["transform"].Value;

            if (element.HasAttribute("class"))
                Class = element.Attributes["class"].Value;
        }

        public string Id { get; set; }
#nullable enable
        public string? Style { get; set; }

        public string? Transform { get; set; }

        public string? Class { get; set; }
#nullable disable

        protected virtual XmlElement AddAttributes(XmlElement xmlElement)
        {
            xmlElement.SetAttribute("id", Id);

            if (Style != null)
                xmlElement.SetAttribute("style", Style);

            if (Transform != null)
                xmlElement.SetAttribute("transform", Transform);

            if (Class != null)
                xmlElement.SetAttribute("class", Class);

            return xmlElement;
        }
#nullable enable
        public abstract XmlElement GetXml(XmlDocument root, string? label = null);
#nullable disable
    }
}
