using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Model {
    public abstract class EntityBase : IEntityBase {
        public int Id { get; set; }
    }
}
