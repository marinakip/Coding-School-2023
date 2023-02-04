using Session_16.Model;
using Session_16.Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Orm.Repositories {
    public class TransactionLineRepository : IEntityRepository<TransactionLine> {
        public void Add(TransactionLine entity) {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public IList<TransactionLine> GetAll() {
            using var context = new AppDbContext();
            return (IList<TransactionLine>)context.TransactionLines;
        }

        public TransactionLine? GetById(Guid id) {
            using var context = new AppDbContext();
            return context.TransactionLines.Where(transactionLine => transactionLine.TransactionLineID == id).SingleOrDefault();
        }

        public void Update(Guid id, TransactionLine entity) {
            using var context = new AppDbContext();
            var dbTransactionLine = context.TransactionLines.Where(transactionLine => transactionLine.TransactionLineID == id).SingleOrDefault();
            if (dbTransactionLine is null)
                return;
            dbTransactionLine.Transaction = entity.Transaction;  
            dbTransactionLine.PetFood = entity.PetFood;
            dbTransactionLine.Pet = entity.Pet;
            dbTransactionLine.SpecialOffer = entity.SpecialOffer;
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new AppDbContext();
            var dbTransactionLine = context.TransactionLines.Where(transactionLine => transactionLine.TransactionLineID == id).SingleOrDefault();
            if (dbTransactionLine is null)
                return;
            context.Remove(dbTransactionLine);
            context.SaveChanges();
        }
    }
}
