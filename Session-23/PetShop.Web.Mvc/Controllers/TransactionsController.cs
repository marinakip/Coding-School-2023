using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;

namespace PetShop.Web.Mvc.Controllers {
    public class TransactionsController : Controller {
        private readonly IEntityRepository<Transaction> _transactionRepository;
        private readonly IEntityRepository<Customer> _customerRepository;
        private readonly IEntityRepository<Employee> _employeeRepository;
        private readonly IEntityRepository<Pet> _petRepository;
        private readonly IEntityRepository<PetFood> _petFoodRepository;

        public TransactionsController(
            IEntityRepository<Customer> customerRepository,
            IEntityRepository<Employee> employeeRepository,
            IEntityRepository<Pet> petRepository,
            IEntityRepository<PetFood> petFoodRepository,
            IEntityRepository<Transaction> transactionRepository) {
           
            _customerRepository = customerRepository;
            _employeeRepository = employeeRepository;
            _petRepository = petRepository;
            _petFoodRepository= petFoodRepository;
            _transactionRepository = transactionRepository;

        }

        // GET: TransactionsController
        public ActionResult Index() {
            var transactions = _transactionRepository.GetAll();
            return View(model: transactions);
        }

        // GET: TransactionsController/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: TransactionsController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: TransactionsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: TransactionsController/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: TransactionsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: TransactionsController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: TransactionsController/Delete/5
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
