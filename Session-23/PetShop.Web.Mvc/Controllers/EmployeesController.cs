using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;
using PetShop.Web.Mvc.Models.Customer;
using PetShop.Web.Mvc.Models.Employee;

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
            if (id == null) {
                return NotFound();
            }

            var employee = _employeeRepository.GetById(id);
            if (employee == null) {
                return NotFound();
            }

            var viewEmployee = new EmployeeDetailsDto {
                Id = employee.Id,
                Name = employee.Name,
                Surname = employee.Surname,
                EmployeeType = employee.EmployeeType,   
                SalaryPerMonth= employee.SalaryPerMonth,    
                Transactions = employee.Transactions.ToList()
            };
            return View(model: viewEmployee);
        }

        // GET: EmployeesController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeCreateDto employee) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }

                var dbEmployee = new Employee(employee.Name, employee.Surname, employee.EmployeeType, employee.SalaryPerMonth);
                _employeeRepository.Add(dbEmployee);
                return RedirectToAction("Index");
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
