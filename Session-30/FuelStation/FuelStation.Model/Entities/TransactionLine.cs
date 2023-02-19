using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Entities {
    /// <summary>
    /// It represents a TransactionLine in a transaction. 
    /// <example>For example, a customer can buy fuel and a product. These represent two transaction lines
    /// with seperate total values in a transaction.</example>
    /// </summary>
    public class TransactionLine : BaseEntity {

        #region Properties
        /// <summary>
        /// Gets or sets the TransactionId of the transaction which is related with the transaction line
        /// </summary>
        public Guid TransactionId { get; set; }
        /// <summary>
        /// Gets or sets the ItemId of the item which is related with the transaction line
        /// </summary>
        public Guid ItemId { get; set; }
        /// <summary>
        /// Gets or sets the quantity of the purchased fuel, product or service.
        /// </summary>
        public int Quantity { get; set; }   
        /// <summary>
        /// Gets or sets the item's price.
        /// </summary>
        public decimal ItemPrice { get; set; }
        /// <summary>
        /// Gets or sets net value which is is calculated by multiplying the quantity with the item price.
        /// </summary>
        public decimal NetValue { get; set; }   
        /// <summary>
        /// Gets or sets the percent of the discount.
        /// </summary>
        public decimal DiscountPercent { get; set; }
        /// <summary>
        /// Gets or sets the discount value which is calculated by multiplying the Net Value with Discount Percent
        /// </summary>
        public decimal DiscountValue { get; set; }
        /// <summary>
        /// Gets or sets Total value which is calculated by subtracting Discount Value from the Net Value
        /// </summary>
        public decimal TotalValue { get; set; }


        #endregion Properties

        #region Constructor
        public TransactionLine(Guid transactionId, Guid itemId, int quantity, decimal itemPrice, 
                        decimal discountPercent) : base() {
            TransactionId = transactionId;
            ItemId = itemId;
            Quantity = quantity;
            ItemPrice = itemPrice;
            NetValue = Quantity * ItemPrice;
            DiscountPercent = discountPercent;
            DiscountValue = NetValue * DiscountPercent;
            TotalValue = NetValue - DiscountValue;

        }
        #endregion Constructor

        #region Relations
        // One to one relation with Transaction
        // One to One relation with Item
        public Transaction Transaction { get; set; } = null!;
        public Item Item  {get; set; } = null!;  

        #endregion Relations
    }
}
