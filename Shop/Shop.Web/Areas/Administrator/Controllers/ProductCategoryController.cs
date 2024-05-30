using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Shop.Model.Entities;
using Shop.Repository;

namespace Shop.Web.Areas.Adminnistrator.Controllers
{
    [Area("Administrator")]
    public class ProductCategoryController : Controller
    {
        private ProductCategoryRepository productCategoryRepo;
        public ProductCategoryController()
        {
            productCategoryRepo = new ProductCategoryRepository();
        }
        public IActionResult Index()
        {
            return View(productCategoryRepo.GetAll().ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductCategory productCategory)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    productCategoryRepo.Insert(productCategory);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View(productCategory);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var productCategory = productCategoryRepo.GetById(id);
            if (productCategory == null)
            {
                return NotFound();
            }
            return View(productCategory);
        }
        [HttpPost]
        public IActionResult Edit(ProductCategory productCategory)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    productCategoryRepo.Update(productCategory);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View(productCategory);
        }
        public IActionResult Delete(int id)
        {
            productCategoryRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
