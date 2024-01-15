using SampleTest.Database;
using SampleTest.Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace SampleTest.Repository.Classes
{
    public class SubCategoryRepo : ISubCategory
    {
        public List<SubCategory> GetAll()
        {
            using (SampleTestEntities1 db = new SampleTestEntities1())
            {
                return db.SubCategories.OrderBy(f => f.Title).ToList();
            }
        }
    }
}