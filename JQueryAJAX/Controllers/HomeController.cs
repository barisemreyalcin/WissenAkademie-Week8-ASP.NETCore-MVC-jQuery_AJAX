using System.Diagnostics;
using JQueryAJAX.Models;
using Microsoft.AspNetCore.Mvc;

namespace JQueryAJAX.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public int Add(int number1, int number2)
		{
			int sum = number1 + number2;
			return sum;
		}

		public CalculateNumbers Calculate(int number1, int number2)
		{
			CalculateNumbers calculate = new CalculateNumbers();
			calculate.Add = number1 + number2;
			calculate.Substract = number1 - number2;
			calculate.Multiply = number1 * number2;
			calculate.Divide = number1 / number2;

			return calculate;
		}

		public IActionResult Personnel()
		{
			return View();
		}

		[HttpPost]
        public JsonResult Personnel(Personnel personnel)
        {
			return Json(personnel);
        }

		[HttpPost]
		public IActionResult PersonnelDetail(Personnel personnel)
		{
			return View("PersonnelDetail", personnel);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
