using Session_16.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Orm.Repositories {
    public interface IEntityRepository<TEntity> {
        //where TEntity : IEntityBase {
        void Add(TEntity entity);
        IList<TEntity> GetAll();
        TEntity? GetById(Guid id);   
        void Update(Guid id, TEntity entity);
        void Delete(Guid id);
    }
}
