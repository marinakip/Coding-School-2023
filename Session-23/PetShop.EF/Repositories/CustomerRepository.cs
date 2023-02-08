using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories {
    public class CustomerRepository : IEntityRepository<Customer> {
        //TODO: Implement Customer repository
        public void Add(Customer entity) {
            throw new NotImplementedException();
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public IList<Customer> GetAll() {
            throw new NotImplementedException();
        }

        public Customer? GetById(int id) {
            throw new NotImplementedException();
        }

        public void Update(int id, Customer entity) {
            throw new NotImplementedException();
        }
    }
}
