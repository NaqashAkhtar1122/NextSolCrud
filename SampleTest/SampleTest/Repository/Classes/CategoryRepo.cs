using SampleTest.Database;
using SampleTest.Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace SampleTest.Repository.Classes
{
    public class CategoryRepo : ICategory
    {
        public List<Category> GetAll()
        {
            using (SampleTestEntities1 db = new SampleTestEntities1())
            {
                return db.Categories.OrderBy(f => f.Title).ToList();
            }
        }

    }
}