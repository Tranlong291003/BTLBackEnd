using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Shop.Model.Entities;
using Shop.Repository;

namespace Shop.Web.Controllers
{
    public class BookTourController : Controller
    {
        private BookTourRepository bookTourRepo;
        public BookTourController()
        {
            bookTourRepo = new BookTourRepository();
        }
        public IActionResult Index()
        {
            return View(bookTourRepo.GetAll().OrderByDescending(p => p.Date).ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(BookTour bookTour)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bookTourRepo.Insert(bookTour);
                    return RedirectToAction("index","Home");

                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View(bookTour);
        }
    }
}
