using Microsoft.AspNetCore.Mvc;
using mvc_test.Models;
namespace mvc_test.Controllers
{
	public class IncomeController : Controller
	{
		public IActionResult Index(float i)
		{
			IncomeModel Icm = new IncomeModel(i * 12);
			return View(Icm);
		}

	}
}
