using FuelStation.EntityFramework.Context;
using FuelStation.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EntityFramework.Repositories {

    public class TransactionLineRepository : IEntityRepository<TransactionLine> {
        public void Add(TransactionLine entity) {
            using var context = new FuelStationDbContext();
            if (entity.Id != Guid.Empty) {
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            }
            context.TransactionLines.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new FuelStationDbContext();
            var dbTransactionLine = context.TransactionLines
               .Where(transactionLine => transactionLine.Id == id)
               .Include(transactionLine => transactionLine.Transaction)
               .Include(transactionLine => transactionLine.Item)
               .SingleOrDefault();
            if (dbTransactionLine is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            context.TransactionLines.Remove(dbTransactionLine);
            context.SaveChanges();

        }

        public IList<TransactionLine> GetAll() {
            using var context = new FuelStationDbContext();
            return context.TransactionLines
               .Include(transactionLine => transactionLine.Transaction)
               .Include(transactionLine => transactionLine.Item).ToList();  
        }

        public TransactionLine? GetById(Guid id) {
            using var context = new FuelStationDbContext();
            return context.TransactionLines
                .Where(transactionLine => transactionLine.Id == id)
                .Include(transactionLine => transactionLine.Transaction)
                .Include(transactionLine => transactionLine.Item)
                .SingleOrDefault();
        }

        public void Update(Guid id, TransactionLine entity) {
            using var context = new FuelStationDbContext();
            var dbTransactionLine = context.TransactionLines
               .Where(transactionLine => transactionLine.Id == id)
               .Include(transactionLine => transactionLine.Transaction)
               .Include(transactionLine => transactionLine.Item)
               .SingleOrDefault();
            if (dbTransactionLine is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbTransactionLine.TransactionId = entity.TransactionId;
            dbTransactionLine.ItemId = entity.ItemId;    //TODO: Check again if these are correct  
            dbTransactionLine.Quantity = entity.Quantity;
            dbTransactionLine.ItemPrice = entity.ItemPrice;
            dbTransactionLine.NetValue = entity.NetValue;
            dbTransactionLine.DiscountPercent = entity.DiscountPercent;
            dbTransactionLine.DiscountValue = entity.DiscountValue;
            dbTransactionLine.TotalValue = entity.TotalValue;
            context.SaveChanges();
        }
    }

    //TODO: Refactor code in all repos, these code is repeated
    //TODO: (NOTE TO SELF: DON'T REFACTOR UNTIL THERE IS EXTRA TIME!!)
}
