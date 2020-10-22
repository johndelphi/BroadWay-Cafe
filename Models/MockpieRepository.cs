using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BroadWay_Cafe.Models
{
    public class MockpieRepository : IPieRepository
    {
        public IEnumerable<Pie> Allpies => new List<Pie>
        {
            new Pie {pieId=1,Name="strawberry pie",Price=12.7m,shortDescription="long description rigthe here"}

        };

        public Pie GetPieById(int pieId)
        {
            return Allpies.FirstOrDefault(p => p.pieId == pieId);
        }
    }
}
