using System;
using System.Collections.Generic;

namespace TeeBox.Domain.DTO
{
    public record HoleDTO
    {
        public int Id { get; internal set; }

        public Int16 Number { get; internal set; }

        public Int16 Par { get; internal set; }

        public Int16 Hcp { get; internal set; }

        public IEnumerable<HoleTeeDTO> HoleTees { get; internal set; }
    }
}
