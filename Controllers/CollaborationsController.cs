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

        // GET: CollaborationsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CollaborationsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CollaborationsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CollaborationsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CollaborationsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CollaborationsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CollaborationsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
