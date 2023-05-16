using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkwadratDesign.Controllers
{
    public class PortfolioController : Controller
    {
        /// <summary>
        /// Default controller method, changes route to /realizacje
        /// </summary>
        /// <returns>Returns view of portfolio page</returns>
        // GET: PortfolioController
        [Route("/realizacje/")]
        public IActionResult Portfolio()
        {
            return View();
        }
    }
}
