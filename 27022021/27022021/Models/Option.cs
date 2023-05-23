using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _27022021.Models
{
    public class Option
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
