using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Operations;
using Shop.Model.Entities;
using Shop.Repository;
using Shop.Web.Models;
using System.Diagnostics;

namespace Shop.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ProductRepository productRepo;
		private readonly PostRepository postRepo;
		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
			productRepo = new ProductRepository();
			postRepo = new PostRepository();
		}

		public IActionResult Index()
		{
			var populerProducts = productRepo.GetAll().OrderByDescending(p => p.ViewCount).Take(9).ToList();
			var newProducts = productRepo.GetAll().OrderByDescending(p => p.DaySubmit).Take(6).ToList();
			var saleProducts = productRepo.GetAll().OrderByDescending(p => p.Promotion).Take(6).ToList();
			var NewPost = postRepo.GetAll().OrderByDescending(p => p.Id).Take(6).ToList();

			var tupleModel = new Tuple<List<Product>, List<Product>, List<Product>, List<Post>>(populerProducts, newProducts, saleProducts, NewPost);
			
			return View(tupleModel);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
		public IActionResult ListProduct()
		{
			var ListProducts = productRepo.GetAll().OrderByDescending(p => p.Id).ToList();
			var tupleModel = new Tuple<List<Product>>(ListProducts);
			return View(tupleModel);
		}
		public IActionResult ProductDetails(int id)
		{
			
			var product = productRepo.GetById(id);
			var relatedProduct = productRepo.GetAll().Where(p => p.CategoryId == product.CategoryId).Take(4).ToList();
			var tupleModel = new Tuple<Product, List<Product>>(product, relatedProduct);
			return View(tupleModel);
		}
		public IActionResult ListPost()
		{
			var ListPosts = postRepo.GetAll().OrderByDescending(p => p.Id).ToList();
			var tupleModel = new Tuple<List<Post>>(ListPosts);
			return View(tupleModel);
		}

		public IActionResult PostDetails(int id)
		{
			var post = postRepo.GetById(id);
			var relatedPosts = postRepo.GetAll().OrderByDescending(p => p.ViewCount).Take(4).ToList();
			var tupleModel = new Tuple<Post, List<Post>>(post, relatedPosts);
			return View(tupleModel);
		}
		public IActionResult About()
		{
			return View();
		}
	}
}