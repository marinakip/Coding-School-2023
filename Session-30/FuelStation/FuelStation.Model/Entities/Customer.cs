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
        public Customer(string name, string surname) : base(name, surname) {
            CardNumber = GenerateCardNumber();
            Transactions = new List<Transaction>();

        }

        /// <summary>
        /// Generates Customer's loyalty card number 
        /// </summary>
        /// <returns>string</returns>
        private string? GenerateCardNumber() {
            Random random = new Random();
            long randomInt = random.NextInt64(1000000000000000, 9999999999999999);
            string cardNumber = $"A{randomInt}";   
            return cardNumber;  
        }
        #endregion Constructor

        #region Relations
        // One to many relationship, one customer has many transactions

        /// <summary>
        /// The list of transactions assosiated with this customer.
        /// </summary>
        public List<Transaction> Transactions { get; set; }
        #endregion Relations
    }
}
