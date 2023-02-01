using Session_16.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Orm.Repositories {

    //TODO: Add inheritance from EntityBase in all model classes, remove IDs
    //TODO: Add inheritance from IEntityRepository and create all repos
    //TODO: Add functionality in Form1 with repos
    public class CustomerRepository {  //: IEntityRepository<Customer> {
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
