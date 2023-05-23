using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _27022021.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
    }
}
