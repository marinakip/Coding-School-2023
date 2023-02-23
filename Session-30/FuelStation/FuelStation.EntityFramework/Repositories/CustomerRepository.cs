using FuelStation.EntityFramework.Context;
using FuelStation.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EntityFramework.Repositories {
    public class CustomerRepository : IEntityRepository<Customer> {
        public void Add(Customer entity) {
            using var context = new FuelStationDbContext();            
            if (entity.Id != default(Guid)) {
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            }
            // Not sure if Id is safe to be initialized in the constructor or after Add to the database
            // since if someone creates a customer with default guid, a generated card number and a name and surname it will be added.
            // Maybe a more secure way it would be to create a list of predefined guids and card numbers and get them from there, to
            // create a new customer.

            if (CardNumberExists(entity)) {
                throw new Exception($"Customer with Card Number {entity.CardNumber} already exists");
            } else {
                context.Customers.Add(entity);
                context.SaveChanges();
            }           
        }

        private bool CardNumberExists(Customer entity) {
            using var context = new FuelStationDbContext();
            var dbCustomer = context.Customers
               .Where(customer => customer.CardNumber == entity.CardNumber).FirstOrDefault();
            if (dbCustomer != null) {
                return true;
            } else {
                return false;
            }
        }

        public void Delete(Guid id) {
            using var context = new FuelStationDbContext();
            var dbCustomer = context.Customers
                .Where(customer => customer.Id == id)
                .Include(customer => customer.Transactions)
                .SingleOrDefault();
            if (dbCustomer is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            context.Customers.Remove(dbCustomer);
            context.SaveChanges();
        }

        public IList<Customer> GetAll() {
            using var context = new FuelStationDbContext();
            return context.Customers.Include(customer => customer.Transactions).ToList();
        }

        public Customer? GetById(Guid id) {
            using var context = new FuelStationDbContext();
            return context.Customers
                .Where(customer => customer.Id == id)
                .Include(customer => customer.Transactions)
                .SingleOrDefault();
        }

        public void Update(Guid id, Customer entity) {
            using var context = new FuelStationDbContext();
            var dbCustomer = context.Customers
                .Where(customer => customer.Id == id)
                .Include(customer => customer.Transactions)
                .SingleOrDefault();
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
