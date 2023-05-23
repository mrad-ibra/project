using _27022021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _27022021.ViewModels
{
    public class VmBase
    {
        public List<Blog> RecentPost { get; set; }
        public List<Social> Socials { get; set; }
        public Contact Contacts { get; set; }
    }
}
