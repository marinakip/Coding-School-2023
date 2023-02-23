using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Entities {
    /// <summary>
    /// It is the class that all entities in Fuel Station inherit from.
    /// It implements IBaseEntity interface.
    /// </summary>
    public class BaseEntity : IBaseEntity {

        #region Properties  
        /// <summary>
        /// Gets or sets the global unique identifier
        /// </summary>
        public Guid Id { get; set; }
        #endregion Properties

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the BaseEntity class
        /// </summary>
        public BaseEntity() {
          // Id = Guid.NewGuid();    // After consideration, Id will be initialized after addition to the database, not here 
        }
        #endregion Constructor
    }
}
