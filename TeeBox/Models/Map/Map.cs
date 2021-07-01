using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TeeBox.Application.Models.Map.Interfaces;

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
    }
}
