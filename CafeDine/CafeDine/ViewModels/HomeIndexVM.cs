using CafeDine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeDine.ViewModels
{
    public class HomeIndexVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Food> Foods { get; set; }

    }
}
