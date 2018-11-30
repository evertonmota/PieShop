using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopping.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryId = 1, CategoryName = "Fuit pies", Description = "All-Fruity Pie" },
                    new Category { CategoryId = 2, CategoryName = "Cheese cakes", Description = "Cheese all the way" },
                    new Category { CategoryId = 3, CategoryName = "Seasonal pies", Description = "Get in the mood for a seaso" },
                };
            }
        }
    }
}