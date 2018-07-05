using DuffManCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuffManCore.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Litter> Litters { get; set; }
        public string CurrentMessage { get; set; }
    }
}
