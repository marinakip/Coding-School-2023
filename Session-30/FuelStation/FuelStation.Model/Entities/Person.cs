using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Entities {
    /// <summary>
    /// It represents all Person entities in Fuel Station.
    /// It inherits <value>Id</value> from <c>BaseEntity</c>
    /// </summary>
    public class Person : BaseEntity {

        #region Properties
        /// <summary>
        /// Gets or sets the first name of the Person in our Fuel Station
        /// </summary>
        public string? Name { get; set; }    

        /// <summary>
        /// Gets or Sets the last name of the Person in our Fuel Station
        /// </summary>
        public string? Surname { get; set; }
        #endregion Properties

        #region Constructor
        /// <summary>
        /// It initializes a new instance of the Person class
        /// </summary>
        /// <param name="id">The global unique identifier of the Person</param>
        /// <param name="name">The first name of the Person</param>
        /// <param name="surname">The last name of the Person</param>
        public Person(Guid id, string name, string surname) : base() {
            Name = name;
            Surname = surname;
        }
        #endregion Constructor
    }
}
