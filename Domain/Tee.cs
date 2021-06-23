using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeeBox.Domain
{
    public class Tee
    {
        public enum TeeColor { 
            White,
            Yellow,
            Blue,
            Red
        }

        public int Id { get; set; }

        public TeeColor Color { get; set; }

        public double Distance { get; set; }
    }
}
