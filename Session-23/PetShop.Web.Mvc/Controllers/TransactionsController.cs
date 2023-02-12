using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;
using PetShop.Web.Mvc.Models.Transaction;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            var newTransaction = new TransactionCreateDto();
            var customers = _customerRepository.GetAll();
            var employees = _employeeRepository.GetAll();
            var pets = _petRepository.GetAll();
            var petFoods = _petFoodRepository.GetAll();

            foreach (var customer in customers) {
                newTransaction.Customers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(customer.Surname, customer.Id.ToString()));
            }

            foreach (var employee in employees) {
                newTransaction.Employees.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(employee.Surname, employee.Id.ToString()));
            }
            foreach (var pet in pets) {
                newTransaction.Pets.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(pet.Breed, pet.Id.ToString()));
            }
            foreach (var petFood in petFoods) {
                newTransaction.PetFoods.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(petFood.AnimalType.ToString(), petFood.Id.ToString()));
            }
            

            return View(model: newTransaction);
        }

        // POST: TransactionsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionCreateDto transaction) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }

                var dbTransaction = new Transaction(transaction.PetPrice, transaction.PetFoodQty, transaction.PetFoodPrice, transaction.TotalPrice) {
                    CustomerId = transaction.CustomerId,
                    EmployeeId = transaction.EmployeeId,
                    PetId = transaction.PetId,  
                    PetFoodId= transaction.PetFoodId   
                };

                _transactionRepository.Add(dbTransaction);
                return RedirectToAction("Index");
            } catch {
                return View();
            }
        }

        // GET: TransactionsController/Edit/5
        public ActionResult Edit(int id) {
            var dbTransaction = _transactionRepository.GetById(id);
            if (dbTransaction == null) {
                return NotFound();
            }

            var newTransaction = new TransactionEditDto {                
                Id = dbTransaction.Id,
                //Date = dbTransaction.Date,
                PetPrice= dbTransaction.PetPrice,   
                PetFoodQty = dbTransaction.PetFoodQty,
                PetFoodPrice = dbTransaction.PetFoodPrice
            };

            var customers = _customerRepository.GetAll();
            var employees = _employeeRepository.GetAll();
            var pets = _petRepository.GetAll();
            var petFoods = _petFoodRepository.GetAll();

            foreach (var customer in customers) {
                newTransaction.Customers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(customer.Surname, customer.Id.ToString()));
            }

            foreach (var employee in employees) {
                newTransaction.Employees.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(employee.Surname, employee.Id.ToString()));
            }
            foreach (var pet in pets) {
                newTransaction.Pets.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(pet.Breed, pet.Id.ToString()));
            }
            foreach (var petFood in petFoods) {
                newTransaction.PetFoods.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(petFood.AnimalType.ToString(), petFood.Id.ToString()));
            }

            return View(newTransaction);
        }

        // POST: TransactionsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TransactionEditDto transaction) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }

                var dbTransaction = _transactionRepository.GetById(id);
                if (dbTransaction == null) {
                    return NotFound();
                }

                //dbTransaction.Date = transaction.Date;
                dbTransaction.PetPrice = transaction.PetPrice;
                dbTransaction.PetFoodQty = transaction.PetFoodQty;
                dbTransaction.PetFoodPrice = transaction.PetFoodPrice;
                
                dbTransaction.CustomerId = transaction.CustomerId;
                dbTransaction.EmployeeId = transaction.EmployeeId;
                dbTransaction.PetId = transaction.PetId;
                dbTransaction.PetFoodId = transaction.PetFoodId;

                _transactionRepository.Update(id, dbTransaction);
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
                _transactionRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }
    }
}
