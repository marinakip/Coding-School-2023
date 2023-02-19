using FuelStation.Model.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FuelStation.Model.Entities {
    /// <summary>
    /// It represents the Employee in our Fuel Station. It inherits from class <c>Person</c>
    /// </summary>
    public class Employee : Person {
        #region Properties
        /// <summary>
        /// Gets or sets the date that the employee has started working in the Fuel Station
        /// </summary>
        public DateTime HireDateStart { get; set; }

        /// <summary>
        /// Gets or sets the date that the employee has stopped working in the Fuel Station
        /// </summary>
        public DateTime HireDateEnd { get; set; }

        /// <summary>
        /// Gets or sets employee's monthly sallary 
        /// </summary>
        public decimal SallaryPerMonth { get; set; }   

        /// <summary>
        /// Gets or Sets employee's job type.
        /// <example>For example, if he is Manager, Staff or Cashier.</example>
        /// </summary>
        public EmployeeType EmployeeType { get; set; }
        #endregion Properties

        #region Constructor
        /// <summary>
        /// It creates a new instance of the Employee in our Fuel Station.
        /// </summary>
        /// <param name="id">The global unique identifier of the Employee. It is inherited from the class <c>Person.</c> </param>
        /// <param name="name">The first name of the Employee. It is inherited from the class <c>Person.</c> </param>
        /// <param name="surname">The last name of the Employee. It is inherited from the class <c>Person.</c></param>
        /// <param name="hireDateStart">The date that the employee has started working </param>
        /// <param name="hireDateEnd">The date that the employee has stopped working </param>
        /// <param name="sallaryPerMonth">Employee's monthly sallary</param>
        /// <param name="employeeType">Employee's job type.</param>
        public Employee(Guid id, string name, string surname, DateTime hireDateStart, 
            DateTime hireDateEnd, decimal sallaryPerMonth, EmployeeType employeeType)  : base(id, name, surname){

            HireDateStart = hireDateStart;
            HireDateEnd = hireDateEnd;
            SallaryPerMonth = sallaryPerMonth;
            EmployeeType = employeeType; 
        }
        #endregion Constructor

        #region Relations
        // One to many relationship, one employee has many transactions

        /// <summary>
        /// The list of transactions assosiated with this employee.
        /// </summary>
        public List<Transaction> transactions = new List<Transaction>();
        #endregion Relations

    }
}
