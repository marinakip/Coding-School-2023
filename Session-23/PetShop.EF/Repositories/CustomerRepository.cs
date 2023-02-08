﻿using Microsoft.EntityFrameworkCore;
using PetShop.EF.Context;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories {
    public class CustomerRepository : IEntityRepository<Customer> {
        public void Add(Customer entity) {
            using var context = new PetShopDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new PetShopDbContext();
            var dbCustomer = context.Customers.Where(customer => customer.Id == id).SingleOrDefault();
            if (dbCustomer is null)
                return;
            context.Remove(dbCustomer);
            context.SaveChanges();
        }

        public IList<Customer> GetAll() {
            using var context = new PetShopDbContext();
            return context.Customers.Include(customer => customer.Transactions).ToList();
        }

        public Customer? GetById(int id) {
            using var context = new PetShopDbContext();
            return context.Customers.Where(customer => customer.Id == id)
                .Include(customer => customer.Transactions).SingleOrDefault();
        }

        public void Update(int id, Customer entity) {
            using var context = new PetShopDbContext();
            var dbCustomer = context.Customers.Where(customer => customer.Id == id).SingleOrDefault();
            if (dbCustomer is null)
                return;
            dbCustomer.Name = entity.Name;
            dbCustomer.Surname = entity.Surname;
            dbCustomer.Phone = entity.Phone;    
            dbCustomer.Tin = entity.Tin;
            context.SaveChanges();
        }
    }
}
