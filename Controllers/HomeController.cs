using Lab_FormSubmit_ListData.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_FormSubmit_ListData.Controllers
{
    public class HomeController(ILogger<HomeController> logger) : Controller
    {
        private readonly ILogger<HomeController> _logger = logger;

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Test(CarListViewModel model)
        {
            return Content("");
        }
    }
}