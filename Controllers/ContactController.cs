using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkwadratDesign.Controllers
{
    public class ContactController : Controller
    {
        // GET: ContactController
        public ActionResult Contact()
        {
            return View();
        }

    }
}
