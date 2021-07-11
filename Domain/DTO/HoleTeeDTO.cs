using TeeBox.Domain.Enum;

namespace TeeBox.Domain.DTO
{
    public record HoleTeeDTO
    {
        public int Id { get; internal set; }

        public double Distance { get; internal set; }

        public int HoleId { get; internal set; }

        public TeeColors Color { get; internal set; }
    }
}
