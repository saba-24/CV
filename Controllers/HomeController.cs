using Microsoft.AspNetCore.Mvc;
using mvc_test.Models;
using System.Diagnostics;


namespace mvc_test.Controllers
{

    public class HomeController : Controller
    {


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public List<List<Edu>> All = [
            [
            new (){name = "N158 Public School", startDate = 2012, endDate = 2015},
            new (){name = "N30 Public School", startDate = 2015, endDate = 2017},
            new (){name = "N63 Public School", startDate = 2017, endDate = 2024},
            new (){name = "University of Georgia", startDate = 2024, endDate = null, GPA = (float?)3.25, major = "Informatics" },
            ],
			[
			new (){name = "Bincom Volunteer Program", startDate = 2025}
			]
			];

		public IActionResult Index()
        {
            return View(All);
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

    }
}
