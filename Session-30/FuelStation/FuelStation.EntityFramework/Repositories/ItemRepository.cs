using FuelStation.EntityFramework.Context;
using FuelStation.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EntityFramework.Repositories {
    public class ItemRepository : IEntityRepository<Item> {
        public void Add(Item entity) {
            using var context = new FuelStationDbContext();
            if (entity.Id != Guid.Empty) {
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            }
            context.Items.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new FuelStationDbContext();
            var dbItem = context.Items
                .Where(Item => Item.Id == id)
                .Include(Item => Item.TransactionLines)
                .SingleOrDefault();
            if (dbItem is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            context.Items.Remove(dbItem);
            context.SaveChanges();
        }

        public IList<Item> GetAll() {
            using var context = new FuelStationDbContext();
            return context.Items.Include(Item => Item.TransactionLines).ToList();
        }

        public Item? GetById(Guid id) {
            using var context = new FuelStationDbContext();
            return context.Items
                .Where(Item => Item.Id == id)
                .Include(Item => Item.TransactionLines)
                .SingleOrDefault();
        }

        public void Update(Guid id, Item entity) {
            using var context = new FuelStationDbContext();
            var dbItem = context.Items
                .Where(Item => Item.Id == id)
                .Include(Item => Item.TransactionLines)
                .SingleOrDefault();
            if (dbItem is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            // Item's Code is auto generated
            dbItem.Description = entity.Description;
            dbItem.ItemType = entity.ItemType;
            dbItem.Price = entity.Price;
            dbItem.Cost = entity.Cost;
            context.SaveChanges();
        }
    }
}
