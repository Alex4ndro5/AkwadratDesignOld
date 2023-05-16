using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkwadratDesign.Controllers
{
    public class AboutController : Controller
    {
        // GET: AboutController
        [Route("/agnieszka-osypanka/")]
        public ActionResult About()
        {
            return View();
        }

    }
}
