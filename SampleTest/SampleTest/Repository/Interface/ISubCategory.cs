using SampleTest.Database;
using System.Collections.Generic;

namespace SampleTest.Repository.Interface
{
    public interface ISubCategory
    {
        List<SubCategory> GetAll();
    }
}