using Microsoft.EntityFrameworkCore;
using Session_16.Model;
using Session_16.Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Orm.Repositories {
    public class PetFoodRepository : IEntityRepository<PetFood> {
        public void Add(PetFood entity) {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();       
        }        

        public IList<PetFood> GetAll() {
            using var context = new AppDbContext();
            return (IList<PetFood>)context.PetFoods;
        }

        public PetFood? GetById(Guid id) {
            using var context = new AppDbContext();
            return context.PetFoods.Where(petFood => petFood.PetFoodID == id)
                .Include(petFood => petFood.TransactionLine).SingleOrDefault();
        }

        public void Update(Guid id, PetFood entity) {
            using var context = new AppDbContext();
            var dbPetFood = context.PetFoods.Where(petFood => petFood.PetFoodID == id).SingleOrDefault();
            if (dbPetFood is null)
                return;
            dbPetFood.AnimalType = entity.AnimalType;
            dbPetFood.PetFoodPrice = entity.PetFoodPrice;
            dbPetFood.PetFoodCost = entity.PetFoodCost;          
            context.SaveChanges();
        }
        public void Delete(Guid id) {
            using var context = new AppDbContext();
            var dbPetFood = context.PetFoods.Where(petFood => petFood.PetFoodID == id).SingleOrDefault();
            if (dbPetFood is null)
                return;
            context.Remove(dbPetFood);
            context.SaveChanges();
        }

        
    }
}
