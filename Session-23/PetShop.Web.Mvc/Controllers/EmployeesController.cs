using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;

namespace PetShop.Web.Mvc.Controllers {
    public class EmployeesController : Controller {
        private readonly IEntityRepository<Employee> _employeeRepository;
        public EmployeesController(IEntityRepository<Employee> employeeRepository) {
            _employeeRepository = employeeRepository;
        }

        // GET: EmployeesController
        public ActionResult Index() {
            var employees = _employeeRepository.GetAll();
            return View(model: employees);
        }

        // GET: EmployeesController/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: EmployeesController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: EmployeesController/Delete/5
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
