using TeeBox.Domain.Enum;

namespace TeeBox.Domain
{
    public class TeeColor
    {
        public int Id { get; set; }

        public TeeColors Color { get; set; }

        public int CourseId { get; set; }
    }
}
