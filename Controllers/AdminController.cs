using Microsoft.AspNetCore.Mvc;

namespace AkwadratDesign.Controllers
{
    public class AdminController : Controller
    {
        [Route("/Admin")]
        public IActionResult Admin()
        {
            return View();
        }
    }
}
