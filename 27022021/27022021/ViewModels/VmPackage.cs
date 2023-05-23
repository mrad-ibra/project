using _27022021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _27022021.ViewModels
{
    public class VmPackage:VmBase
    {
        public List<TourPackage> TourPackages { get; set; }
        public List<Partner> Partners { get; set; }
        public List<Feedback> Feedbacks { get; set; }
    }
}
