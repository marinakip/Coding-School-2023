using FuelStation.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EntityFramework.Repositories {
    public interface IEntityRepository<TEntity> where TEntity : BaseEntity {
        IList<TEntity> GetAll();
        TEntity? GetById(Guid id);
        void Add(TEntity entity);
        void Update(Guid id, TEntity entity);
        void Delete(Guid id);
    }
}
