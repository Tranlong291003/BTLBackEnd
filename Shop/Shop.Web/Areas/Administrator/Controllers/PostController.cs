using Microsoft.AspNetCore.Mvc;
using Shop.Model.Entities;
using Shop.Repository;

namespace Shop.Web.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class PostController : Controller
    {
        private PostRepository postRepo;
        public PostController()
        {
            postRepo = new PostRepository();
        }
        public IActionResult Index()
        {
            return View(postRepo.GetAll().ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Post post)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    postRepo.Insert(post);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View(post);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var post = postRepo.GetById(id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }
        [HttpPost]
        public IActionResult Edit(Post post)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    postRepo.Update(post);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View(post);
        }
        public IActionResult Delete(int id)
        {
            postRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
