using Microsoft.AspNetCore.Mvc;

using HomeDash.ViewModels;

namespace HomeDash.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var viewModel = new HomeViewModel();

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Error()
        {
            return View();
        }
    }
}