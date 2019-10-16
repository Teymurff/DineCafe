using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CafeDine.Models
{
    public class Slider
    {
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Image { get; set; }
        [Required, StringLength(100)]
        public string Title { get; set; }
        [Required, StringLength(100)]
        public string Paragraph { get; set; }
        [Required, StringLength(100)]
        public string Button { get; set; }

 

    }
}
