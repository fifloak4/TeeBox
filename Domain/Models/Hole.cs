using System;

namespace TeeBox.Domain
{
    public class Hole
    {
        public int Id { get; set; }

        public short Number { get; set; }

        public short Par { get; set; }

        public short Hcp { get; set; }

        public int CourseId { get; set; }

    }
}
