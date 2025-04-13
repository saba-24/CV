using Microsoft.AspNetCore.Mvc;

namespace mvc_test.Controllers
{
	public class IncomeController : Controller
	{
		public IActionResult Index(float i)
		{
			return View(i);
		}
	}
}
