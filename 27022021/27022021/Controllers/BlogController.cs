using _27022021.Data;
using _27022021.Models;
using _27022021.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _27022021.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? id)
        {
            IList<Blog> blogs;
            if (id != null)
            {
                blogs = _context.Blogs.Where(b => b.CategoryId == id).ToList();
            }
            else
            {
                blogs = _context.Blogs.ToList();
            }

            VmBlog model = new VmBlog()
            {
                Blogs = blogs,
                Socials = _context.Socials.ToList(),
                Contacts = _context.Contacts.FirstOrDefault(),
                RecentPost = _context.Blogs.OrderByDescending(o => o.AddedDate).Take(3).ToList()
            };
           
            return View(model);
        }

        public IActionResult Details(int id)
        {
            int catId = _context.Blogs.Find(id).CategoryId;
            VmBlog model = new VmBlog()
            {
                Blog = _context.Blogs.Include(u => u.User).ThenInclude(us => us.SocialToUsers).ThenInclude(s => s.Social).FirstOrDefault(b => b.Id == id),
                Categories = _context.Categories.Include(b => b.Blogs).ToList(),
                RecentBlogs = _context.Blogs.OrderByDescending(o => o.AddedDate).Take(3).ToList(),
                RelatedBlogs = _context.Blogs.Where(b => (b.CategoryId == catId && b.Id != id)).ToList(),
                Comments = _context.Comments.Where(c => c.BlogId == id).ToList(),
                Socials = _context.Socials.ToList(),
                Contacts = _context.Contacts.FirstOrDefault(),
                RecentPost = _context.Blogs.OrderByDescending(o => o.AddedDate).Take(3).ToList()
            };
            return View(model);
        }
    }
}
