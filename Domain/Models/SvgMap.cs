namespace TeeBox.Domain.Models
{
    public class SvgMap
    {
        public int Id { get; set; }

        public string File { get; set; }

        public int OriginalId { get; set; }

        public int? PreviousId { get; set; }

        public int? NextId { get; set; }

        public int HoleId { get; set; }

    }
}
