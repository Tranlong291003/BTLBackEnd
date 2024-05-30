using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using Shop.Model.Entities;

namespace Shop.Web.Areas.Administrator.Controllers
{
	[Area("Administrator")]
	public class AccessController : Controller
    {
        ShopOnlineContext db = new ShopOnlineContext();
        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("UserName") == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            if (HttpContext.Session.GetString("UserName") == null)
            {
                var u = db.Users.Where(x => x.Username.Equals(user.Username) && x.Password.Equals(user.Password)).FirstOrDefault();
                if (u != null)
                {
                    HttpContext.Session.SetString("UserName", u.Username.ToString());
					return RedirectToAction("index", "Product");
				}
            }
            return View("Login");
        }
	}
}
