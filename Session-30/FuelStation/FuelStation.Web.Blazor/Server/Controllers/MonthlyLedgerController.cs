using FuelStation.EntityFramework.Repositories;
using FuelStation.Model.Entities;
using FuelStation.Web.Blazor.Shared.MonthlyLedgerDataTransferObject;
using Microsoft.AspNetCore.Mvc;


namespace FuelStation.Web.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class MonthlyLedgerController : ControllerBase {

        private readonly IEntityRepository<Employee> _employeeRepository;
        private readonly IEntityRepository<Transaction> _transactionRepository;

        public MonthlyLedgerController(IEntityRepository<Employee> employeeRepository, IEntityRepository<Transaction> transactionRepository) { 
            _employeeRepository = employeeRepository;          
            _transactionRepository = transactionRepository;           
        }

        // GET: <MonthlyLedgerController>
        [HttpGet]
        public async Task<IEnumerable<MonthlyLedgerDto>> Get() {
            List<MonthlyLedgerDto> monthlyLedgers = new();
            var transactions = _transactionRepository.GetAll().ToList();
            var employees = _employeeRepository.GetAll().ToList();

            decimal totalTransactions = 0;
            decimal totalSalaryEmployees = 0;
            decimal rent = 5000m;  //TODO: this should be given by the user
            
            foreach (var transaction in transactions) {
                totalTransactions += transaction.TotalValue;
            }
            foreach (var employee in employees) {
                totalSalaryEmployees += employee.SallaryPerMonth;
            }

            var groupedTransactions = transactions.GroupBy(transactions => new { transactions.Date.Year, transactions.Date.Month })
                .Select(grouped => new MonthlyLedgerDto {
                    Year = grouped.Key.Year,
                    Month = grouped.Key.Month,
                    Income = totalTransactions,
                    Expenses = totalSalaryEmployees + rent,
                    Total = totalTransactions - (totalSalaryEmployees + rent)
                });

            foreach (var grouped in groupedTransactions) {
                monthlyLedgers.Add(grouped);
            }
            return groupedTransactions;
        }
    }
}
