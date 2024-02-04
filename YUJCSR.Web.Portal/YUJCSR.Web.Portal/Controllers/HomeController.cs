using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using YUJCSR.Web.Portal.Business;
using YUJCSR.Web.Portal.Models;

namespace YUJCSR.Web.Portal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            ProjectManager obj = new ProjectManager();
            var list = obj.GetProjects().Take(3);
            //var list = (APIResponse)data.Result;
            ViewBag.Projects = list;
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
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
