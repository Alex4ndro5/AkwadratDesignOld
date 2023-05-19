using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace AkwadratDesign.Controllers
{
    public class AdminController : Controller
    {
        /// <summary>
        /// Default controller method, changes route to /admin
        /// </summary>
        /// <returns>Returns view of admin page</returns>
        [Route("/admin")]
        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult Upload()
        {
            return View();
        }
    }
}
 