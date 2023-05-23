using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _27022021.Models
{
    public class SocialToUser
    {
        [Key]
        public int Id { get; set; }
        public int SocialId { get; set; }
        public Social Social { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public string Link{ get; set; }
    }
}
