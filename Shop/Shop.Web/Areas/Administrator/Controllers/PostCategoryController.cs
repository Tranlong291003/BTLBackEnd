using Microsoft.AspNetCore.Mvc;
using Shop.Model.Entities;
using Shop.Repository;

namespace Shop.Web.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class PostCategoryController : Controller
    {
        private PostCategoryRepository postCategoryRepo;
        public PostCategoryController()
        {
            postCategoryRepo = new PostCategoryRepository();
        }
        public IActionResult Index()
        {
            return View(postCategoryRepo.GetAll().ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(PostCategory postCategory)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    postCategoryRepo.Insert(postCategory);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View(postCategory);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var postCategory = postCategoryRepo.GetById(id);
            if (postCategory == null)
            {
                return NotFound();
            }
            return View(postCategory);
        }
        [HttpPost]
        public IActionResult Edit(PostCategory postCategory)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    postCategoryRepo.Update(postCategory);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View(postCategory);
        }
        public IActionResult Delete(int id)
        {
            postCategoryRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
