using Microsoft.AspNetCore.Mvc;
using Shop.Model.Entities;
using Shop.Repository;

namespace Shop.Areas.Admin.Controllers
{
    [Area("Administrator")]
    public class ProductController : Controller
    {
        private ProductRepository productRepo;
        public ProductController()
        {
            productRepo = new ProductRepository();
        }
        public IActionResult Index()
        {

            return View(productRepo.GetAll().ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    productRepo.Insert(product);
                    return RedirectToAction("Index");
                }

            }
            catch (Exception ex)
            {

                ModelState.AddModelError("", ex.Message);
            }
            return View(product);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = productRepo.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    productRepo.Update(product);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

                ModelState.AddModelError("", ex.Message);
            }
            return View(product);
        }
        public IActionResult Delete(int id)
        {
            productRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
