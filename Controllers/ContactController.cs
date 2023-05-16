using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkwadratDesign.Controllers
{
    public class ContactController : Controller
    {
        /// <summary>
        /// Default controller method,changes route to /kontakt
        /// </summary>
        /// <returns>Returns view of contact page</returns>
        // GET: ContactController
        [Route("/kontakt/")]
        public ActionResult Contact()
        {
            return View();
        }

    }
}
