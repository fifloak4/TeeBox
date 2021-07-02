﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeeBox.Domain.Models
{
    public class SvgMap
    {
        public int Id { get; set; }

        public string File { get; set; }

        public int OriginalId { get; set; }

        public int PreviousId { get; set; }

        public int NextId { get; set; }
    }
}