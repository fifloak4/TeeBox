using System.Collections.Generic;

namespace TeeBox.Domain.Records
{
    public record HoleTeesColors(Hole Hole, IEnumerable<TeeColorTee> Tees);

    public record TeeColorTee(Tee Tee, TeeColor Color);
}
