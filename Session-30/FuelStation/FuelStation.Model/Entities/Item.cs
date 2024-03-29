﻿using FuelStation.Model.Enumerations;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Entities {
    /// <summary>
    /// It represents the Item in our Fuel Station. An item can be either Fuel, Product or Service.
    /// </summary>
    public class Item : BaseEntity {
        #region Properties
        /// <summary>
        /// Gets or sets the fuel station's item unique code
        /// </summary>
        public string? Code { get; set; }  

        /// <summary>
        /// Gets or sets fuel station's item description
        /// </summary>
        public string? Description { get; set; }    

        /// <summary>
        /// Gets or sets fuel's station item type. It can either be Fuel, Product or Service
        /// </summary>
        public ItemType ItemType { get; set; }  

        /// <summary>
        /// Gets or sets item's price. Notice that Price is diffent from <value>Cost</value>
        /// and it refers to the amount of money that the buyer is going to spend.
        /// </summary>
        public decimal Price { get; set; } 
        
        /// <summary>
        /// Gets or sets item's cost. Notice that Cost is different from <value>Price</value> and 
        /// it refers to the original amount of money spent by the store, not the buyer.
        /// </summary>
        public decimal Cost { get; set; }
        #endregion Properties

        #region Constructor
        /// <summary>
        /// It creates an instance of the Item in our fuel station.
        /// </summary>
        /// <param name="code">The item's unique code</param>
        /// <param name="description">The item's summary and details </param>
        /// <param name="itemType">The item's type. It can either be <c>Fuel</c>, <c>Product</c>, or <c>Service</c></param>
        /// <param name="price">The item's price. Notice that Price is diffent from <value>Cost</value> and it
        /// refers to the amount of money that the buyer is going to spend.</param>
        /// <param name="cost">The item's cost. Nptice that cost is different from <value>Price</value> and it refers to 
        /// the original amount of money spent by the store, not the buyer.</param>
        public Item(string description, ItemType itemType, decimal price, decimal cost) : base() {
            Code = GenerateItemCode();    
            Description = description;
            ItemType = itemType;
            Price = price;
            Cost = cost;
            TransactionLines = new List<TransactionLine>();

        }
        #endregion Constructor


        #region Help Methods
        /// <summary>
        /// Generates Item code using EAN-13 algorithm for barcodes
        /// </summary>    
        private string? GenerateItemCode() {
            string country = "520"; // Greece
            string manufacturer = "9876"; // our fuel station code goes here, this is an example
            string product = GenerateProductCode(); // should be 5 digits 
            string temp = $"{country}{manufacturer}{product}";
            int sum = 0;
            int digit = 0;
            
            // Checksum digit calculation
            for (int i = temp.Length; i >= 1; i--) {
               
                digit = Convert.ToInt32(temp.Substring(i - 1, 1));                
                               
                if (i % 2 == 0) { // odd  
                    sum += digit * 3;
                } else { // even
                    sum += digit * 1;
                }
            }
            int checkSum = (10 - (sum % 10)) % 10;
            return $"{temp}{checkSum}";
        }

        /// <summary>
        /// It generates a random 5 digit code for our product code
        /// </summary>        
        private string GenerateProductCode() {
           Random random = new Random();
            return $"{random.Next(10000, 99999)}";
        }
        #endregion Help Methods



        #region Relations
        // One to many relationship, one item has many transaction lines

        /// <summary>
        /// The list of transactions assosiated with this employee.
        /// </summary>
        public List<TransactionLine> TransactionLines { get; set; }
        #endregion Relations
    }
}
