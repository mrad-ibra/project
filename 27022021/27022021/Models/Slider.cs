using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _27022021.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }

        public string Title{ get; set; }
        public string SubTitle{ get; set; }
        public string Image{ get; set; }
    }
}
