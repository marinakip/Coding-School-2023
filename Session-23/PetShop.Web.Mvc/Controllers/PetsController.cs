using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;

namespace PetShop.Web.Mvc.Controllers {
    public class PetsController : Controller {
        private readonly IEntityRepository<Pet> _petRepository;

        public PetsController(IEntityRepository<Pet> petRepository) {
            _petRepository = petRepository;
        }

        // GET: PetsController
        public ActionResult Index() {
            var pets = _petRepository.GetAll();
            return View(model: pets);
        }

        // GET: PetsController/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: PetsController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: PetsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: PetsController/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: PetsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: PetsController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: PetsController/Delete/5
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
