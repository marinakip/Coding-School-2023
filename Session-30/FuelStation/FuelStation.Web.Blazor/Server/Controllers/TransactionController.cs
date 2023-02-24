using FuelStation.EntityFramework.Repositories;
using FuelStation.Model.Entities;
using FuelStation.Web.Blazor.Shared.CustomerDataTransferObjects;
using FuelStation.Web.Blazor.Shared.EmployeeDataTranferObjects;
using FuelStation.Web.Blazor.Shared.TransactionDataTranferObjects;
using FuelStation.Web.Blazor.Shared.TransactionLineDataTransferObjects;
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
                PaymentMethod= transaction.PaymentMethod,   
                CustomerName = transaction.Customer.Name,
                CustomerSurname = transaction.Customer.Surname,
                EmployeeName = transaction.Employee.Name,
                EmployeeSurname = transaction.Employee.Surname,                
                CustomerId = transaction.CustomerId,
                EmployeeId = transaction.EmployeeId,
            });
        }

        // GET <TransactionController>/450F87A0-9FC8-4C0E-BA65-B45EEFEB9B12
        [HttpGet("{id}")]
        public TransactionEditDto GetById(Guid id) {
            var result = _transactionRepository.GetById(id);
            var customers = _customerRepository.GetAll();
            var employees = _employeeRepository.GetAll();
            return new TransactionEditDto {
                Id = id,
                Date = result.Date,
                TotalValue = result.TotalValue,
                PaymentMethod = result.PaymentMethod,
                CustomerName = result.Customer.Name,
                CustomerSurname = result.Customer.Surname,
                EmployeeName = result.Employee.Name,
                EmployeeSurname = result.Employee.Surname,
                CustomerId = result.CustomerId,
                EmployeeId = result.EmployeeId,

                Customers = customers.Select(customer => new CustomerListDto {
                    Id = customer.Id,
                    Name = customer.Name,
                    Surname = customer.Surname,
                    CardNumber = customer.CardNumber
                }).ToList(),

                Employees = employees.Select(employee => new EmployeeListDto {
                    Id = employee.Id,
                    Name = employee.Name,
                    Surname = employee.Surname,
                    EmployeeType = employee.EmployeeType,
                    HireDateStart = employee.HireDateStart,
                    HireDateEnd = employee.HireDateEnd,
                    SallaryPerMonth = employee.SallaryPerMonth
                }).ToList(),
                
                TransactionLines = result.TransactionLines.Select(transactionLine => new TransactionLineListDto {
                    Id = transactionLine.Id,
                    Quantity = transactionLine.Quantity,
                    ItemPrice = transactionLine.ItemPrice,
                    NetValue = transactionLine.NetValue,
                    DiscountPercent = transactionLine.DiscountPercent,
                    DiscountValue = transactionLine.DiscountValue,
                    TotalValue = transactionLine.TotalValue,
                    TransactionId = transactionLine.TransactionId,
                    ItemId = transactionLine.ItemId,
                    ItemCode = transactionLine.Item.Code,
                    ItemDescription = transactionLine.Item.Description
                }).ToList()

            };
        }

        // POST <TransactionController>
        [HttpPost]
        public async Task Post(TransactionEditDto transaction) {
            var newTransaction = new Transaction(transaction.EmployeeId, transaction.CustomerId,
                                 transaction.PaymentMethod, transaction.TotalValue);
                _transactionRepository.Add(newTransaction);


            foreach (var line in transaction.TransactionLines) {
                var transactionLine = new TransactionLine(newTransaction.Id, line.ItemId, line.Quantity, 
                                      line.ItemPrice, line.DiscountPercent);                

                _transactionLineRepository.Add(transactionLine);
            }
        }


        // PUT <TransactionController>/450F87A0-9FC8-4C0E-BA65-B45EEFEB9B12
        [HttpPut("{id}")]
        public async Task Put(TransactionEditDto transaction) {
            var itemToUpdate = _transactionRepository.GetById(transaction.Id);
            itemToUpdate.Date = transaction.Date;
            itemToUpdate.EmployeeId = transaction.EmployeeId;
            itemToUpdate.CustomerId = transaction.CustomerId;
            itemToUpdate.PaymentMethod = transaction.PaymentMethod;
            itemToUpdate.TotalValue = transaction.TotalValue;

            itemToUpdate.TransactionLines = transaction.TransactionLines
                .Select(transactionLine => new TransactionLine(transaction.Id, transactionLine.ItemId, transactionLine.Quantity,
                                      transactionLine.ItemPrice, transactionLine.DiscountPercent)).ToList();



            foreach (var line in transaction.TransactionLines) {
                var transactionLine = new TransactionLine(itemToUpdate.Id, line.ItemId, line.Quantity,
                                      line.ItemPrice, line.DiscountPercent);

                // _transactionLineRepository.Update(transactionLine.Id, transactionLine);
            }

            _transactionRepository.Update(transaction.Id, itemToUpdate);
        }


        // DELETE <TransactionController>/450F87A0-9FC8-4C0E-BA65-B45EEFEB9B12
        [HttpDelete("{id}")]
        public void Delete(Guid id) {
            _transactionRepository.Delete(id);
        }
    }
}
