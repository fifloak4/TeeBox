using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeeBox.Domain
{
    public class TeeColor
    {
        public int Id { get; set; }

        public enum TeeColors
        {
            White,
            Yellow,
            Blue,
            Red
        }
        public TeeColors Color { get; set; }

        public int CourseId { get; set; }
    }
}
