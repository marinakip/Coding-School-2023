using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;

namespace PetShop.Web.Mvc.Controllers {
    public class MonthlyReportController : Controller {
        private readonly IEntityRepository<Employee> _employeeRepository;
        private readonly IEntityRepository<Transaction> _transactionRepository;
        public MonthlyReportController(IEntityRepository<Employee> employeeRepository, IEntityRepository<Transaction> transactionRepository) {
            _employeeRepository = employeeRepository;
            _transactionRepository = transactionRepository;
        }

        // GET: MonthlyReport
        public ActionResult Index() {
            //decimal expenses = CalculateMonthlyExpenses();
            //decimal income = CalculateMonthlyIncome();
            //decimal profit = expenses - income;
            decimal  test = -99999999.999999m;
            //return View(model: profit);
            return View(model: test);
        }

        //TODO: Filter by month
        private decimal CalculateMonthlyExpenses() {
            int rent = 2000;
            IList<Employee> employees = _employeeRepository.GetAll();
            //var TotalNumberOfEmployees = employees.Count;
            int TotalNumberOfStaff = employees.Where(employee => employee.EmployeeType == Model.Enums.EmployeeType.Staff).Count();
            int TotalNumberOfManagers = employees.Where(employee => employee.EmployeeType == Model.Enums.EmployeeType.Manager).Count();
            decimal SalaryStaffPerMonth = 713.00m;
            decimal SalaryManagerPerMonth = 926.90m;
            decimal TotalSalaryPerMonthOfAllEmployees = (SalaryStaffPerMonth * TotalNumberOfStaff) + (SalaryManagerPerMonth * TotalNumberOfManagers);
            decimal TotalExpensesPerMonth = rent + TotalSalaryPerMonthOfAllEmployees;   //TODO: needs extra:  TotalOfPetFoodsCostPerMonth + TotalOfPetsCostPerMonth   TODO: add to constructor PetRepo and PetFoodRepo
            return (TotalExpensesPerMonth);
        }

        //TODO: Filter Transactions Per month and get TotalCostsForAllPetsPerMonth and TotalCostsForAllPetFoodsPerMonth
        //TODO: Filter transactions and get the TotalPrice of all transactions in the range of 30 days from the creation of ledger
        //      or selected month from dropdown or give monthly ledger for the whole year month per line without select

        private decimal CalculateMonthlyIncome() {
            throw new NotImplementedException();
        }


        // GET: MonthlyReport/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: MonthlyReport/Create
        public ActionResult Create() {
            return View();
        }

        // POST: MonthlyReport/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: MonthlyReport/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: MonthlyReport/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: MonthlyReport/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: MonthlyReport/Delete/5
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
