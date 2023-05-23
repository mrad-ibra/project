using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _27022021.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public int Name { get; set; }

        [MaxLength(15)]
        public string Phone { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(150)]
        public string Subject { get; set; }
        public string Content { get; set; }
        public string AddedDate { get; set; }
    }
}
