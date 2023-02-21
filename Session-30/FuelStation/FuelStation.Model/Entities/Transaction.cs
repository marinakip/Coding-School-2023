using FuelStation.Model.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Entities {
    /// <summary>
    /// It represents a Transaction in our Fuel Station. It inherits <value>Id</value> from <c>BaseEntity</c>.
    /// </summary>
    public class Transaction : BaseEntity {

        #region Properties
        /// <summary>
        /// Gets or sets the Date the transaction was created. 
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Gets or sets the employee connected with the transaction.
        /// </summary>
        public Guid EmployeeId { get; set; }    
        /// <summary>
        /// Gets or sets the customer connected with the transaction.
        /// </summary>
        public Guid CustomerId { get; set; }
        /// <summary>
        /// Gets or sets the different type of payment method. Credit card or cash are supported.
        /// </summary>
        public PaymentMethod PaymentMethod { get; set; }    
        /// <summary>
        /// Gets or sets the total value of the transaction. It is the sum of transaction lines' total value.
        /// </summary>
        public decimal TotalValue { get; set; } 
        #endregion Properties


        #region Constructor        
        public Transaction(Guid employeeId, Guid customerId, PaymentMethod paymentMethod, decimal totalValue) : base () {
            Date = DateTime.Now;
            EmployeeId = employeeId;
            CustomerId = customerId;
            PaymentMethod = paymentMethod;
            TotalValue = totalValue;
            TransactionLines = new List<TransactionLine>();
        }
        #endregion Constructor

        #region Relations
        // One Employee has Many Transactions
        // One Customer has Many Transactions
        // One Transaction with Many TransactionLines
        public Employee Employee { get; set; } = null!;
        public Customer Customer { get; set; } = null!;
        public List<TransactionLine> TransactionLines { get; set; }
        #endregion Relations
    }
}
