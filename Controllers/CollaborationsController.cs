using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkwadratDesign.Controllers
{
    public class CollaborationsController : Controller
    {
        // GET: CollaborationsController
        public IActionResult Collaborations()
        {
            return View();
        }

    }
}
