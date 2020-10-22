using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BroadWay_Cafe.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Allcategories { get; }
    }
}
