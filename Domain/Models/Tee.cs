using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeeBox.Domain
{
    public class Tee
    {
        public int Id { get; set; }

        public double Distance { get; set; }

        public int TeeColorId { get; set; }

        public int HoleId { get; set; }

    }
}
