using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BroadWay_Cafe.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> Allpies { get; }
        IEnumerable<Pie> piesofTheWeek { get; }

        Pie GetPieById(int pieId);
    }
}
