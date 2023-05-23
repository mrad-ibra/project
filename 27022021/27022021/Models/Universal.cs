using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _27022021.Models
{
    public class Universal
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Subtitle{ get; set; }
        public string Section { get; set; }
    }
}
