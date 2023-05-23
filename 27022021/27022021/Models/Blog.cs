using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _27022021.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public DateTime AddedDate { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
