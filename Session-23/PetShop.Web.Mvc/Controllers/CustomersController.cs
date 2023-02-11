using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;
using PetShop.Web.Mvc.Models.Customer;

namespace PetShop.Web.Mvc.Controllers {
    public class CustomersController : Controller {
        private readonly IEntityRepository<Customer> _customerRepository;

        public CustomersController(IEntityRepository<Customer> customerRepository) {
            _customerRepository = customerRepository;
        }

        // GET: CustomersController
        public ActionResult Index() {
            var customers = _customerRepository.GetAll().ToList();   
            return View(model: customers);
        }

        // GET: CustomersController/Details/5
        public ActionResult Details(int id) {

            if (id == null) {
                return NotFound();
            }

            var customer = _customerRepository.GetById(id);
            if (customer == null) {
                return NotFound();
            }

            var viewCustomer = new CustomerDetailsDto {
                Id = customer.Id,
                Name = customer.Name,
                Surname = customer.Surname,
                Phone = customer.Phone,
                Tin = customer.Tin,
                Transactions = customer.Transactions.ToList()
            };
            return View(model: viewCustomer);
           
        }

        // GET: CustomersController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: CustomersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerCreateDto customer) {
            if (!ModelState.IsValid) {
                return View();
            }

            var dbCustomer = new Customer(customer.Name, customer.Surname, customer.Phone, customer.Tin);            
            _customerRepository.Add(dbCustomer);
            return RedirectToAction("Index");
        }

        // GET: CustomersController/Edit/5
        public ActionResult Edit(int id) {
            var dbCustomer = _customerRepository.GetById(id);
            if (dbCustomer == null) {
                return NotFound();
            }

            var viewCustomer = new CustomerEditDto {
                Id = dbCustomer.Id,
                Name = dbCustomer.Name,
                Surname = dbCustomer.Surname,
                Phone = dbCustomer.Phone,
                Tin = dbCustomer.Tin
            };
            return View(model: viewCustomer);
        }

        // POST: CustomersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CustomerEditDto customer) {
            if (!ModelState.IsValid) {
                return View();
            }

            var dbCustomer = _customerRepository.GetById(id);
            if (dbCustomer == null) {
                return NotFound();
            }

            dbCustomer.Name = customer.Name;
            dbCustomer.Surname = customer.Surname;
            dbCustomer.Phone = customer.Phone;
            dbCustomer.Tin = customer.Tin;
            
            _customerRepository.Update(id, dbCustomer);
            return RedirectToAction(nameof(Index));
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
