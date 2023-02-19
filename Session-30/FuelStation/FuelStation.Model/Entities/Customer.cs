using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Entities {
    /// <summary>
    /// It represents the Customer in our Fuel Station. It inherits from class <c>Person</c>
    /// </summary>
    public class Customer : Person {
        #region Properties
        /// <summary>
        /// Gets or sets the customer's loyalty card number
        /// </summary>
        public string? CardNumber { get; set; }
        #endregion Properties

        #region Constructor
        /// <summary>
        /// It creates a new instance of the Customer in our Fuel Station
        /// </summary>       
        /// <param name="name">The first name of the Customer. It is inherited from the class <c>Person.</c></param>
        /// <param name="surname">The last name of the Customer. It is inherited from the class <c>Person.</c></param>
        /// <param name="cardNumber">The loyalty card number of the Customer. It is inherited from the class <c>Person.</c> </param>
        public Customer(string name, string surname, string cardNumber) : base(name, surname) {
            CardNumber = cardNumber;    
        }
        #endregion Constructor

        #region Relations
        // One to many relationship, one customer has many transactions

        /// <summary>
        /// The list of transactions assosiated with this customer.
        /// </summary>
        public List<Transaction> transactions = new List<Transaction>();
        #endregion Relations
    }
}
