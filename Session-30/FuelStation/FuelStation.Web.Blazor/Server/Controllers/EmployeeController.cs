using FuelStation.EntityFramework.Repositories;
using FuelStation.Model.Entities;
using FuelStation.Web.Blazor.Shared.EmployeeDataTranferObjects;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using Microsoft.AspNetCore.Http;
using FuelStation.Web.Blazor.Client.Pages.Employee;

namespace FuelStation.Web.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase {

        private readonly IEntityRepository<Employee> _employeeRepository;

        public EmployeeController(IEntityRepository<Employee> employeeRepository) {
            _employeeRepository = employeeRepository;
        }

        // GET: <EmployeeController>
        [HttpGet]
        public async Task<IEnumerable<EmployeeListDto>> Get() {
            var result = _employeeRepository.GetAll();
            return result.Select(employee => new EmployeeListDto {
                Id = employee.Id,
                Name = employee.Name,
                Surname = employee.Surname,
                HireDateStart = employee.HireDateStart,
                HireDateEnd = employee.HireDateEnd,
                SallaryPerMonth = employee.SallaryPerMonth,
                EmployeeType = employee.EmployeeType
            });
        }

        // GET <EmployeeController>/450F87A0-9FC8-4C0E-BA65-B45EEFEB9B12
        [HttpGet("{id}")]
        public async Task<EmployeeEditDto> GetById(Guid id) {
            var result = _employeeRepository.GetById(id);
            return new EmployeeEditDto {
                Id = id,
                Name = result.Name,
                Surname = result.Surname,
                HireDateStart = result.HireDateStart,
                HireDateEnd = result.HireDateEnd,
                SallaryPerMonth = result.SallaryPerMonth,
                EmployeeType = result.EmployeeType
            };
        }

        // POST <EmployeeController>
        [HttpPost]
        public async Task Post(EmployeeCreateDto employee) {
            var newEmployee = new Employee(
                employee.Name,
                employee.Surname,
                //DateTime.Now,
                (DateTime)employee.HireDateStart,
                (DateTime)employee.HireDateEnd,
                employee.SallaryPerMonth,
                employee.EmployeeType
            );
            _employeeRepository.Add(newEmployee);
        }

        // PUT <EmployeeController>/450F87A0-9FC8-4C0E-BA65-B45EEFEB9B12
        [HttpPut]
        public async Task Put(EmployeeEditDto employee) {
            var itemToUpdate = _employeeRepository.GetById(employee.Id);
            itemToUpdate.Name = employee.Name;
            itemToUpdate.Surname = employee.Surname;
            itemToUpdate.HireDateStart = (DateTime) employee.HireDateStart;
            itemToUpdate.HireDateEnd = (DateTime) employee.HireDateEnd;
            itemToUpdate.SallaryPerMonth = employee.SallaryPerMonth;
            itemToUpdate.EmployeeType = employee.EmployeeType;
            _employeeRepository.Update(employee.Id, itemToUpdate);
        }

        // DELETE <EmployeeController>/450F87A0-9FC8-4C0E-BA65-B45EEFEB9B12
        [HttpDelete("{id}")]
        public void Delete(Guid id) {
            _employeeRepository.Delete(id);
        }
    }
}
