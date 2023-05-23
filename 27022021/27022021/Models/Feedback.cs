using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _27022021.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Position { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public string Desc { get; set; }
    }
}
