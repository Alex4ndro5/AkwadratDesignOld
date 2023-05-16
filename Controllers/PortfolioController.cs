using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkwadratDesign.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: PortfolioController
        [Route("/realizacje/")]
        public IActionResult Portfolio()
        {
            return View();
        }
    }
}
