using _27022021.Data;
using _27022021.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _27022021.Controllers
{
    public class GalleryController : Controller
    {
        private readonly AppDbContext _context;

        public GalleryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmGallery model = new VmGallery()
            {
                Galleries = _context.Galleries.ToList(),
                Partners = _context.Partners.ToList(),
                Feedbacks = _context.Feedbacks.ToList(),
                Contacts = _context.Contacts.FirstOrDefault(),
                RecentPost = _context.Blogs.OrderByDescending(o => o.AddedDate).Take(3).ToList(),
                Socials = _context.Socials.ToList()
            };
            return View(model);
        }
    }
}
