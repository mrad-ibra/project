using _27022021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _27022021.ViewModels
{
    public class VmBlog : VmBase
    {
        public Blog Blog { get; set; }
        public IList<Blog> Blogs { get; set; }
        public List<Blog> RecentBlogs { get; set; }
        public List<Blog> RelatedBlogs { get; set; }
        public List<Category> Categories { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
