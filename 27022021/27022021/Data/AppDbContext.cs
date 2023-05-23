using _27022021.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _27022021.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<About> About{ get; set; }
        public DbSet<Blog> Blogs{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<ChooseUs> ChooseUs{ get; set; }
        public DbSet<Comment> Comments{ get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Feedback> Feedbacks{ get; set; }
        public DbSet<Gallery> Galleries{ get; set; }
        public DbSet<Message> Messages{ get; set; }
        public DbSet<Option> Options{ get; set; }
        public DbSet<Partner> Partners{ get; set; }
        public DbSet<Service> Services{ get; set; }
        public DbSet<Slider> Sliders{ get; set; }
        public DbSet<Social> Socials{ get; set; }
        public DbSet<SocialToUser> SocialToUsers{ get; set; }
        public DbSet<Subscribe> Subscribes{ get; set; }
        public DbSet<TourPackage> TourPackages{ get; set; }
        public DbSet<Universal> Universals{ get; set; }
        public DbSet<User> Users{ get; set; }
    }
}
