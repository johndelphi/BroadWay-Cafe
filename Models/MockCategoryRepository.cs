using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BroadWay_Cafe.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1,CategoryName="fruit pies", Description="All- fruity pies"},
                new Category{CategoryId=2,CategoryName="Cheese cakes",Description="contains mazerela cheese"}  
            };

        public IEnumerable<Category> categories => throw new NotImplementedException();
    }
    }

