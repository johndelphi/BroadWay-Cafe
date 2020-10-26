using BroadWay_Cafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BroadWay_Cafe.ViewModels
{
    public class PieListViewModel
    {  
       public IEnumerable<Pie> Pies { get; set; }
        public string currentCategory { get; set; }
    }
}
