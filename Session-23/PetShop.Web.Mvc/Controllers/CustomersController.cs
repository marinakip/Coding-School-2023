using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;

namespace PetShop.Web.Mvc.Controllers {
    public class CustomersController : Controller {
        private readonly IEntityRepository<Customer> _customerRepository;

        public CustomersController(IEntityRepository<Customer> customerRepository) {
            _customerRepository = customerRepository;
        }

        // GET: CustomersController
        public ActionResult Index() {
            var customers = _customerRepository.GetAll();   
            return View(model: customers);
        }

        // GET: CustomersController/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: CustomersController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: CustomersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: CustomersController/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: CustomersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: CustomersController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: CustomersController/Delete/5
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
