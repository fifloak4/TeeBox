﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
