using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeeBox.Domain.Records
{
    public record HoleTeesColors(Hole Hole, List<TeeColorTee> Tees);

    public record TeeColorTee(Tee Tee, TeeColor Color);
}
