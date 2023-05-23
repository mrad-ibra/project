using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _27022021.Models
{
    public class Partner
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [MaxLength(250)]
        public string Link { get; set; }
    }
}
