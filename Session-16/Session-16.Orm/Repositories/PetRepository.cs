using Microsoft.EntityFrameworkCore;
using Session_16.Model;
using Session_16.Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Orm.Repositories {
    public class PetRepository : IEntityRepository<Pet> {
        public void Add(Pet entity) {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public IList<Pet> GetAll() {
            using var context = new AppDbContext();
            return (IList<Pet>)context.Pets;
        }

        public Pet? GetById(Guid id) {
            using var context = new AppDbContext();
            return context.Pets.Where(pet => pet.PetID == id)
                .Include(pet => pet.TransactionLine).SingleOrDefault();
        }

        public void Update(Guid id, Pet entity) {
            using var context = new AppDbContext();
            var dbPet = context.Pets.Where(pet => pet.PetID == id).SingleOrDefault();
            if (dbPet is null)
                return;
            dbPet.Breed = entity.Breed;
            dbPet.Type = entity.Type;
            dbPet.Status = entity.Status;
            dbPet.Price= entity.Price;
            dbPet.Cost = entity.Cost;           
            context.SaveChanges();
        }
        public void Delete(Guid id) {
            using var context = new AppDbContext();
            var dbPet = context.Pets.Where(pet => pet.PetID == id).SingleOrDefault();
            if (dbPet is null)
                return;
            context.Remove(dbPet);
            context.SaveChanges();
        }
    }
}
