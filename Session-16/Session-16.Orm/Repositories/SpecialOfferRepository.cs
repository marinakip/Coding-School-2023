using Microsoft.EntityFrameworkCore;
using Session_16.Model;
using Session_16.Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Orm.Repositories {
    public class SpecialOfferRepository : IEntityRepository<SpecialOffer> {
        public void Add(SpecialOffer entity) {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public IList<SpecialOffer> GetAll() {
            using var context = new AppDbContext();
            return (IList<SpecialOffer>)context.SpecialOffers;
        }

        public SpecialOffer? GetById(Guid id) {
            using var context = new AppDbContext();
            return context.SpecialOffers.Where(specialOffer => specialOffer.SpecialOfferID == id)
                .Include(specialOffer => specialOffer.TransactionLine).SingleOrDefault();
        }

        public void Update(Guid id, SpecialOffer entity) {
            using var context = new AppDbContext();
            var dbSpecialOffer = context.SpecialOffers.Where(specialOffer => specialOffer.SpecialOfferID == id).SingleOrDefault();
            if (dbSpecialOffer is null)
                return;
            // It doesn't have properties to Update, so probably shouldn't implement this interface
            
        }

        public void Delete(Guid id) {
            using var context = new AppDbContext();
            var dbSpecialOffer = context.SpecialOffers.Where(specialOffer => specialOffer.SpecialOfferID == id).SingleOrDefault();
            if (dbSpecialOffer is null)
                return;
            context.Remove(dbSpecialOffer);
            context.SaveChanges();
        }        
    }
}
