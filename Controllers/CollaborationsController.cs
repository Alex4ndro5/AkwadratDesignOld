using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkwadratDesign.Controllers
{
    public class CollaborationsController : Controller
    {
        /// <summary>
        /// Default controller method, changes route to /wspolpraca
        /// </summary>
        /// <returns>Returns view of collaborations page</returns>
        // GET: CollaborationsController
        [Route("/wspolpraca/")]
        public IActionResult Collaborations()
        {
            return View();
        }

    }
}
