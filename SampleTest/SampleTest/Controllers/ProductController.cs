using Newtonsoft.Json;
using SampleTest.Database;
using SampleTest.Repository.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.UI;

namespace SampleTest.Controllers
{
    public class ProductController : Controller
    {
        CategoryRepo CatRepo = new CategoryRepo();
        SubCategoryRepo SubCatRepo = new SubCategoryRepo();
        ProductRepo ProductRepo = new ProductRepo();
        // GET: Product
        public ActionResult Index()
        {
            var list = ProductRepo.GetAll().ToList();
            ViewBag.Category = CatRepo.GetAll().ToList();
            ViewBag.SubCategory = SubCatRepo.GetAll().ToList();
            return View(list);
        }

        [HttpGet]
        public ActionResult GetSubCats(int Id)
        {
            var subCats = new SelectList(SubCatRepo.GetAll().Where(f => f.CatID == Id).ToList(), "ID", "Title");
            return Json(subCats, JsonRequestBehavior.AllowGet);
        }

        public bool AddUpdate(Product model)
        {
            if (model.ID == 0)
            {
                ProductRepo.Add(model);
            }
            else
            {
                ProductRepo.Update(model);
            }
            return true;
        }

        public bool Delete(int Id)
        {
            ProductRepo.Delete(Id);
            return true;
        }
    }
}