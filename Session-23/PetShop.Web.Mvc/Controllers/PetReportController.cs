using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PetShop.Web.Mvc.Controllers {
    public class PetReportController : Controller {
        // GET: PetReportController
        public ActionResult Index() {
            var test = "Test";
            return View(model: test);
        }

        // GET: PetReportController/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: PetReportController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: PetReportController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: PetReportController/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: PetReportController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: PetReportController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: PetReportController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }
    }
}
