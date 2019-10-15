﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeDine.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Paragraph { get; set; }

        public string Button { get; set; }

        public string Image { get; set; }

        public bool IsActive { get; set; }
    }
}
