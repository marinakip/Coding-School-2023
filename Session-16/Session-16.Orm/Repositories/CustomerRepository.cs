using Microsoft.EntityFrameworkCore;
using Session_16.Model;
using Session_16.Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Orm.Repositories {

    //TODO: Add inheritance from EntityBase in all model classes, remove IDs --DOESN'T WORK, Id from EntityBase is invalid database name 
    //TODO: Add inheritance from IEntityRepository and create all repos
    //TODO: Add functionality in Form1 with repos
    public class CustomerRepository : IEntityRepository<Customer> {
        public void Add(Customer entity) {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new AppDbContext();
            var dbCustomer = context.Customers.Where(customer => customer.CustomerID == id).SingleOrDefault();
            if (dbCustomer is null)
                return;
            context.Remove(dbCustomer);
            context.SaveChanges();
        }

        public IList<Customer> GetAll() {
            using var context = new AppDbContext();
            return (IList<Customer>)context.Customers;
        }

        public Customer? GetById(Guid id) {
            using var context = new AppDbContext();
            return context.Customers.Where(customer => customer.CustomerID == id)
                .Include(customer => customer.Transaction)
                .SingleOrDefault();
        }

        public void Update(Guid id, Customer entity) {
            using var context = new AppDbContext();
            var dbCustomer = context.Customers.Where(customer => customer.CustomerID == id).SingleOrDefault();
            if (dbCustomer is null)
                return;
            dbCustomer.Name = entity.Name;
            dbCustomer.Surname = entity.Surname;
            dbCustomer.Phone = entity.Phone;
            //dbCustomer.TIN = entity.TIN; // TIN should not be able to change
            context.SaveChanges();
        }
    }
}
