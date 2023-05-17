using AkwadratDesign.Models;
using AkwadratDesign.Models.DbModels;
using Microsoft.AspNetCore.Mvc;

namespace AkwadratDesign.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Project());
        }

        [HttpPost]

        public ActionResult Create(Project project)
        {
            if(ModelState.IsValid)
            {
                using(DatabaseContext db = new DatabaseContext())
                {
                    db.Projects.Add(project);
                    db.SaveChanges();
                }
                return RedirectToAction("Upload");
            }
            return View(new Project());
        }

    }
}
