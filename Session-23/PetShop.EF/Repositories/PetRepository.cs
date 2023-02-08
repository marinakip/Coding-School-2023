using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories {
    public class PetRepository : IEntityRepository<Pet> {
        //TODO: Implement Pet repository
        public void Add(Pet entity) {
            throw new NotImplementedException();
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public IList<Pet> GetAll() {
            throw new NotImplementedException();
        }

        public Pet? GetById(int id) {
            throw new NotImplementedException();
        }

        public void Update(int id, Pet entity) {
            throw new NotImplementedException();
        }
    }
}
