using _27022021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _27022021.ViewModels
{
    public class VmGallery : VmBase
    {
        public List<Gallery> Galleries { get; set; }
        public List<Partner> Partners { get; set; }
        public List<Feedback> Feedbacks { get; set; }
    }
}
