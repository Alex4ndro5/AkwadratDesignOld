using AkwadratDesign.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AkwadratDesign.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Default controller method
        /// </summary>
        /// <returns>Returns view of landing page</returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Default controller method, changes route to /polityka-prywatnosci
        /// </summary>
        /// <returns>Returns view of privacy page</returns>
        [Route("/polityka-prywatnosci/")]
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