using Microsoft.AspNetCore.Mvc;

namespace AkwadratDesign.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Admin()
        {
            return View();
        }
    }
}
