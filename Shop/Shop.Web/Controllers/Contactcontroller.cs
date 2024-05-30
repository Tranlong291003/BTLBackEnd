using Microsoft.AspNetCore.Mvc;
using Shop.Model.Entities;
using Shop.Repository;

namespace Shop.Web.Controllers
{
    public class ContactController : Controller
    {
        private ContactRepository contactRepo;
        public ContactController()
        {
            contactRepo = new ContactRepository();
        }
        public IActionResult Index()
        {
			// Lấy thông báo từ TempData
			string successMessage = TempData["SuccessMessage"] as string;

			// Truyền thông báo vào ViewBag
			ViewBag.SuccessMessage = successMessage;
			return View(contactRepo.GetAll().OrderByDescending(p => p.Id).ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Contact contact)
        {
			TempData["SuccessMessage"] = "Thêm sản phẩm thành công.";

			try
			{
                if (ModelState.IsValid)
                {
                    contactRepo.Insert(contact);
                    return RedirectToAction("index", "home");
                }

            }
            catch (Exception ex)
            {

                ModelState.AddModelError("", ex.Message);
            }
            return View(contact);
        }
    }
}
