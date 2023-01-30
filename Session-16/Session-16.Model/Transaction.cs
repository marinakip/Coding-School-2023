using Session_16.Model.old_session_11_files;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Model {
    public class Transaction {
        public Guid TransactionID { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        public Guid CustomerID { get; set; }

        [Required]
        public Guid EmployeeID { get; set; }

        [Required]
        public Guid PetID { get; set; }

        public double PetPrice { get; set; }

        [Required]
        public Guid PetFoodID { get; set; }

        public double PetFoodQty { get; set; }
        public double PetFoodPrice { get; set; }
        public double TotalPrice { get; set; }

        public Transaction(Guid customerID, Guid employeeID, Guid petID, Guid petFoodID) {
            TransactionID = Guid.NewGuid();
            TransactionDate = DateTime.Now;
            CustomerID = customerID;
            EmployeeID = employeeID;
            PetID = petID;
            PetFoodID = petFoodID;
        }    
    }
}
