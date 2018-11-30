using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopping.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> Pies {
            get
            {
                return new List<Pie>
                {
                    new Pie {PieId = 1, Name="Strawberry Pie", Price=15.95M, ShortDescription="", ImageThumbnaiUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg"},
                    new Pie {PieId = 2, Name="Cheese cake", Price=18.95M, ShortDescription="", ImageThumbnaiUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg"},
                    new Pie {PieId = 3, Name="Rhuarb Pie", Price=25.95M, ShortDescription="",ImageThumbnaiUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg"},
                    new Pie {PieId = 4, Name="Pumpkin Pie", Price=19.95M, ShortDescription="", ImageThumbnaiUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg"},

                };
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        Pie IPieRepository.GetById(int pieId)
        {
            throw new NotImplementedException();
        }
    }
}
