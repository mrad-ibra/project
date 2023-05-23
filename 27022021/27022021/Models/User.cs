using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _27022021.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
        public string UserName  { get; set; }
        public string Password  { get; set; }
        public string Desc  { get; set; }

        public List<Blog> Blogs { get; set; }
        public List<SocialToUser> SocialToUsers { get; set; }
    }
}
