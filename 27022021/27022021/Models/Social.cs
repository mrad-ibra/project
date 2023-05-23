using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _27022021.Models
{
    public class Social
    {
        [Key]
        public int Id { get; set; }

        public string Icon { get; set; }
        public string Link { get; set; }

        public List<SocialToUser> SocialToUsers { get; set; }
    }
}
