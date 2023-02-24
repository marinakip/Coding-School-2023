using FuelStation.EntityFramework.Repositories;
using FuelStation.Model.Entities;
using FuelStation.Web.Blazor.Shared.TransactionDataTranferObjects;
using Microsoft.AspNetCore.Mvc;


namespace FuelStation.Web.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase {

        private readonly IEntityRepository<Customer> _customerRepository;
        private readonly IEntityRepository<Employee> _employeeRepository;
        private readonly IEntityRepository<Transaction> _transactionRepository;
        private readonly IEntityRepository<TransactionLine> _transactionLineRepository;

        public TransactionController(IEntityRepository<Customer> customerRepository,
            IEntityRepository<Employee> employeeRepository,
            IEntityRepository<Transaction> transactionRepository,
            IEntityRepository<TransactionLine> transactionLineRepository) {

            _customerRepository = customerRepository;
            _employeeRepository = employeeRepository;
            _transactionRepository = transactionRepository;
            _transactionLineRepository = transactionLineRepository;
        }

        // GET: <TransactionController>
        [HttpGet]
        public IEnumerable<TransactionListDto> Get() {
            var result = _transactionRepository.GetAll();
            return result.Select(transaction => new TransactionListDto {
                Id = transaction.Id,
                Date = transaction.Date,
                TotalValue = transaction.TotalValue,
                CustomerName = transaction.Customer.Name,
                CustomerSurname = transaction.Customer.Surname,
                EmployeeName = transaction.Employee.Name,
                EmployeeSurname = transaction.Employee.Surname,                
                CustomerId = transaction.CustomerId,
                EmployeeId = transaction.EmployeeId,
            });
        }

        // GET <TransactionController>/5
        [HttpGet("{id}")]
        public string Get(int id) {
            return "value";
        }

        // POST <TransactionController>
        [HttpPost]
        public void Post([FromBody] string value) {
        }

        // PUT <TransactionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE <TransactionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
