using SampleTest.Database;
using System.Collections.Generic;

namespace SampleTest.Repository.Interface
{
    public interface IProduct
    {
        List<Product> GetAll();
        bool Add(Product user);
        bool Update(Product user);
        bool Delete(int Id);
    }
}