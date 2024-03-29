﻿using System;
using System.Collections.Generic;

namespace Labb3EF_Final.Models
{
    public partial class Registration
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }

        public virtual Course Course { get; set; } = null!;
        public virtual Student Student { get; set; } = null!;
    }
}
