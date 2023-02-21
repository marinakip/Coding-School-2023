using FuelStation.EntityFramework.Context;
using FuelStation.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EntityFramework.Repositories {
    public class CustomerRepository : IEntityRepository<Customer> {
        public void Add(Customer entity) {
            using var context = new FuelStationDbContext();
            if (entity.Id != null) {
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            }
            context.Customers.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new FuelStationDbContext();
            var dbCustomer = context.Customers.SingleOrDefault(Customer => Customer.Id == id);
            if (dbCustomer is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            context.Customers.Remove(dbCustomer);
            context.SaveChanges();
        }

        public IList<Customer> GetAll() {
            using var context = new FuelStationDbContext();
            return context.Customers.ToList();
        }

        public Customer? GetById(Guid id) {
            using var context = new FuelStationDbContext();
            return context.Customers.SingleOrDefault(Customer => Customer.Id == id);
        }

        public void Update(Guid id, Customer entity) {
            using var context = new FuelStationDbContext();
            var dbCustomer = context.Customers.SingleOrDefault(Customer => Customer.Id == id);
            if (dbCustomer is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbCustomer.Name = entity.Name;
            dbCustomer.Surname = entity.Surname;            
            // Card Number is auto generated
            context.SaveChanges();
        }
    }
}
