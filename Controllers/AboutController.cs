using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkwadratDesign.Controllers
{
    /// <summary>
    /// About view controller
    /// </summary>
    public class AboutController : Controller
    {
        /// <summary>
        /// Default controller method, changes route to /wspolpraca
        /// </summary>
        /// <returns>Returns view of about page</returns>
        // GET: AboutController
        [Route("/agnieszka-osypanka/")]
        public ActionResult About()
        {
            return View();
        }

    }
}
