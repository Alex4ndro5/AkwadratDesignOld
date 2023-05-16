using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkwadratDesign.Controllers
{
    public class ContactController : Controller
    {
        // GET: ContactController
        [Route("/kontakt/")]
        public ActionResult Contact()
        {
            return View();
        }

    }
}
