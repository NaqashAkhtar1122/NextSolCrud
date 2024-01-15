using SampleTest.Database;
using SampleTest.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SampleTest.Repository.Classes
{
    public class ProductRepo : IProduct
    {
        public bool Add(Product product)
        {
            using (SampleTestEntities1 db = new SampleTestEntities1())
            {
                try
                {
                    db.Products.Add(product);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool Delete(int Id)
        {
            using (SampleTestEntities1 db = new SampleTestEntities1())
            {
                try
                {
                    var existing = db.Products.Find(Id);
                    if (existing != null)
                    {
                        db.Products.Remove(existing);
                        db.SaveChanges();
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public List<Product> GetAll()
        {
            using (SampleTestEntities1 db = new SampleTestEntities1())
            {
               return db.Products.OrderBy(x => x.Title).ToList();
            }
        }

        public bool Update(Product product)
        {
            using (SampleTestEntities1 db = new SampleTestEntities1())
            {
                try
                {
                    var existing = db.Products.Find(product.ID);
                    if (existing != null)
                    {
                        existing.Title = product.Title;
                        existing.CatID = product.CatID;
                        existing.SubCatID = product.SubCatID;
                        db.SaveChanges();
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}