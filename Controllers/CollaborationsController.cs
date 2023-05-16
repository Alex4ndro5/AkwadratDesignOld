using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkwadratDesign.Controllers
{
    public class CollaborationsController : Controller
    {
        // GET: CollaborationsController
        [Route("/wspolpraca/")]
        public IActionResult Collaborations()
        {
            return View();
        }

    }
}
