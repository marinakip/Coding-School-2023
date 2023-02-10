using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;

namespace PetShop.Web.Mvc.Controllers {
    public class PetFoodsController : Controller {
        private readonly IEntityRepository<PetFood> _petFoodRepository;

        public PetFoodsController(IEntityRepository<PetFood> petFoodRepository) {
            _petFoodRepository= petFoodRepository;
        }

        // GET: PetFoodsController
        public ActionResult Index() {
            var petFoods = _petFoodRepository.GetAll();
            return View(model: petFoods);
        }

        // GET: PetFoodsController/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: PetFoodsController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: PetFoodsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: PetFoodsController/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: PetFoodsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: PetFoodsController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: PetFoodsController/Delete/5
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
