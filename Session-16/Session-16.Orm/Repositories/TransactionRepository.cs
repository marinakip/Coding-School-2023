using Microsoft.EntityFrameworkCore;
using Session_16.Model;
using Session_16.Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Orm.Repositories {
    public class TransactionRepository : IEntityRepository<Transaction> {
        public void Add(Transaction entity) {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }             

        public IList<Transaction> GetAll() {
            using var context = new AppDbContext();
            return (IList<Transaction>)context.Transactions;
        }

        public Transaction? GetById(Guid id) {
            using var context = new AppDbContext();
            return context.Transactions.Where(transaction => transaction.TransactionID == id).SingleOrDefault();                
        }

        public void Update(Guid id, Transaction entity) {
            using var context = new AppDbContext();
            var dbTransaction = context.Transactions.Where(transaction => transaction.TransactionID == id).SingleOrDefault();
            if (dbTransaction is null)
                return;
            dbTransaction.TransactionDate = entity.TransactionDate;  //maybe we shouldn't alter transaction date
            dbTransaction.TotalPrice = entity.TotalPrice;
            dbTransaction.Customer = entity.Customer;
            dbTransaction.Employee = entity.Employee;
            context.SaveChanges();      
        }

        public void Delete(Guid id) {
            using var context = new AppDbContext();
            var dbTransaction = context.Transactions.Where(transaction => transaction.TransactionID == id).SingleOrDefault();
            if (dbTransaction is null)
                return;
            context.Remove(dbTransaction);
            context.SaveChanges();
        }
    }
}
