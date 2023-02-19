using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Entities {
    /// <summary>
    ///  Defines what properties Fuel Station entities should implement.
    ///  In our case, all entities should implement <value>Id</value>.
    /// </summary>
    public interface IEntityBase {

        /// <summary>
        /// Defines that the global unique identifier should be implemented in all entities
        /// </summary>
        Guid Id { get; set; }
    }
}
