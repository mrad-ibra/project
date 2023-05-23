using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _27022021.Models
{
    public class TourPackage
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Column(TypeName = "tinyint")]
        public byte Day { get; set; }

        [Column(TypeName = "tinyint")]
        public byte Night { get; set; }
    }
}
