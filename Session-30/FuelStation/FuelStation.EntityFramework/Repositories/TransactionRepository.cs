using FuelStation.EntityFramework.Context;
using FuelStation.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EntityFramework.Repositories {
    public class TransactionRepository : IEntityRepository<Transaction> {
        public void Add(Transaction entity) {
            using var context = new FuelStationDbContext();
            if (entity.Id != Guid.Empty) {
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            }
            context.Transactions.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new FuelStationDbContext();
            var dbTransaction = context.Transactions
               .Where(Transaction => Transaction.Id == id)
               .Include(Transaction => Transaction.Customer)     //TODO: Change in all repos parameters to lowercase
               .Include(Transaction => Transaction.Employee)     //TODO: Check again all repos
               .Include(Transaction => Transaction.TransactionLines)
               .SingleOrDefault();
            if (dbTransaction is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            context.Transactions.Remove(dbTransaction);
            context.SaveChanges();
        }

        public IList<Transaction> GetAll() {
            using var context = new FuelStationDbContext();
            return context.Transactions
               .Include(Transaction => Transaction.Customer)
               .Include(Transaction => Transaction.Employee)
               .Include(Transaction => Transaction.TransactionLines).ToList();
        }

        public Transaction? GetById(Guid id) {
            using var context = new FuelStationDbContext();
           return context.Transactions
               .Where(Transaction => Transaction.Id == id)
               .Include(Transaction => Transaction.Customer)
               .Include(Transaction => Transaction.Employee)
               .Include(Transaction => Transaction.TransactionLines)
               .SingleOrDefault();
        }

        public void Update(Guid id, Transaction entity) {
            using var context = new FuelStationDbContext();
            var dbTransaction = context.Transactions
               .Where(Transaction => Transaction.Id == id)
               .Include(Transaction => Transaction.Customer)
               .Include(Transaction => Transaction.Employee)
               .Include(Transaction => Transaction.TransactionLines)
               .SingleOrDefault();
            if (dbTransaction is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbTransaction.Date = entity.Date;
            dbTransaction.PaymentMethod = entity.PaymentMethod;
            dbTransaction.TotalValue = entity.TotalValue;
            dbTransaction.CustomerId = entity.CustomerId;
            dbTransaction.EmployeeId = entity.EmployeeId;
            context.SaveChanges();

        }
    }
}
