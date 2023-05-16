using AkwadratDesign.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace AkwadratDesign.Controllers
{
    public class AdminController : Controller
    {
        private IAccountService accountService;
        public AdminController(IAccountService _accountService)
        {
            accountService = _accountService;
        }
        /// <summary>
        /// Default controller method, changes route to /admin
        /// </summary>
        /// <returns>Returns view of admin page</returns>
        [Route("/admin")]
        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult Login(string login, string password, IAccountService accountService)
        {
            var account = accountService.Login(login, password);
            if (account != null)
            {
                HttpContext.Session.SetString("login", login);
                return RedirectToAction("Upload");
            }
            else
            {
                return RedirectToAction("Admin");
            }
        }

        public IActionResult Upload()
        {
            return View();
        }
    }
}
