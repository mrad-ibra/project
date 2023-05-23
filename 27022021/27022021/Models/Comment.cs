using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _27022021.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }

        [ForeignKey("BlogId")]
        public Blog Blog { get; set; }

        public int? CommentId { get; set; }
        [ForeignKey("CommentId")]
        public Comment ParentComment { get; set; }

        public DateTime AddedDate { get; set; }
    }
}
