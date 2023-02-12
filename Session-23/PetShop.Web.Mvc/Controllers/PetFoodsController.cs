using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;
using PetShop.Web.Mvc.Models.Employee;
using PetShop.Web.Mvc.Models.PetFood;

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
            if (id == null) {
                return NotFound();
            }

            var petFood = _petFoodRepository.GetById(id);
            if (petFood == null) {
                return NotFound();
            }

            var viewPetFood = new PetFoodDetailsDto {
                Id = petFood.Id,
                AnimalType = petFood.AnimalType,
                Price = petFood.Price,
                Cost = petFood.Cost,
                Transactions = petFood.Transactions.ToList()
            };
            return View(model: viewPetFood);
        }

        // GET: PetFoodsController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: PetFoodsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PetFoodCreateDto petFood) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }

                var dbPetFood = new PetFood(petFood.AnimalType, petFood.Price, petFood.Cost);
                _petFoodRepository.Add(dbPetFood);
                return RedirectToAction("Index");
            } catch {
                return View();
            }
        }

        // GET: PetFoodsController/Edit/5
        public ActionResult Edit(int id) {
            
            var dbPetFood = _petFoodRepository.GetById(id);
            if (dbPetFood == null) {
                return NotFound();
            }

            var viewPetFood = new PetFoodEditDto {
                Id = dbPetFood.Id,
                AnimalType = dbPetFood.AnimalType,
                Price = dbPetFood.Price,
                Cost = dbPetFood.Cost
            };
            return View(model: viewPetFood);
           
        }

        // POST: PetFoodsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PetFoodEditDto petFood) {
            if (!ModelState.IsValid) {
                return View();
            }

            var dbPetFood = _petFoodRepository.GetById(id);
            if (dbPetFood == null) {
                return NotFound();
            }

            dbPetFood.AnimalType = petFood.AnimalType;
            dbPetFood.Price = petFood.Price;
            dbPetFood.Cost = petFood.Cost;

            _petFoodRepository.Update(id, dbPetFood);
            return RedirectToAction(nameof(Index));
        }

        // GET: PetFoodsController/Delete/5
        public ActionResult Delete(int id) {
            var dbPetFood = _petFoodRepository.GetById(id);
            if (dbPetFood == null) {
                return NotFound();
            }
            var viewPetFood = new PetFoodDeleteDto {
                Id = dbPetFood.Id,
                AnimalType = dbPetFood.AnimalType,
                Price = dbPetFood.Price,
                Cost = dbPetFood.Cost
            };
            return View(model: viewPetFood);
        }

        // POST: PetFoodsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                _petFoodRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }
    }
}
