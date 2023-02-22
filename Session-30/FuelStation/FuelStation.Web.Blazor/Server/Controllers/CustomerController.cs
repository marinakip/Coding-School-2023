using FuelStation.EntityFramework.Repositories;
using FuelStation.Model.Entities;
using FuelStation.Web.Blazor.Shared.CustomerDataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;


namespace FuelStation.Web.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase {

        private readonly IEntityRepository<Customer> _customerRepository;
        public CustomerController(IEntityRepository<Customer> customerRepository) {
            _customerRepository = customerRepository;
        }

        // GET: <CustomerController>
        [HttpGet]
        public async Task<IEnumerable<CustomerListDto>> Get() {

            var result = _customerRepository.GetAll();
            return result.Select(customer => new CustomerListDto {
                Id = customer.Id,
                Name = customer.Name,
                Surname = customer.Surname,
                CardNumber = customer.CardNumber
            });
        }

        // GET <CustomerController>/450F87A0-9FC8-4C0E-BA65-B45EEFEB9B12        
        [HttpGet("{id}")]
        public async Task<CustomerEditDto> GetById(Guid id) {
            var result = _customerRepository.GetById(id);
            return new CustomerEditDto {
                Id = id,
                Name = result.Name,
                Surname = result.Surname,
                CardNumber = result.CardNumber                
            };
        }

        // POST <CustomerController>
        [HttpPost]
       // public async Task Post(CustomerEditDto customer) {            
        public async Task Post(CustomerCreateDto customer) {            
            var newCustomer = new Customer(customer.Name, customer.Surname);           
            _customerRepository.Add(newCustomer);
        }

        // PUT <CustomerController>/450F87A0-9FC8-4C0E-BA65-B45EEFEB9B12
        [HttpPut("{id}")]
        public void Put(CustomerEditDto customer) {
            var itemToUpdate = _customerRepository.GetById(customer.Id);
            itemToUpdate.Name = customer.Name;
            itemToUpdate.Surname = customer.Surname;
            // itemToUpdate.CardNumber = customer.CardNumber; //this is generated, not sure if it is updated by hand
            _customerRepository.Update(customer.Id, itemToUpdate);
        }

        // DELETE <CustomerController>/450F87A0-9FC8-4C0E-BA65-B45EEFEB9B12
        [HttpDelete("{id}")]
        public void Delete(Guid id) {
            _customerRepository.Delete(id);
        }
    }
}
