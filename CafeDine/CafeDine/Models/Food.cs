using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CafeDine.Models
{
    public class Food
    {
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Logo { get; set; }
        [Required, StringLength(100)]
        public string Title { get; set; }
        [Required, StringLength(300)]
        public string Paragraph { get; set; }
    }
}
