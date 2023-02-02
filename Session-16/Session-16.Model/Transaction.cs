using Session_16.Model.old_session_11_files;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Model {

    /* In Each Transaction we have 1 Employee, 1 Customer that can buy 1 Pet but can buy many PetFoods, so we use List<PetFood> PetFoods */
    public class Transaction {

        #region Properties
        public Guid TransactionID { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }
        public double PetPrice { get; set; }
        public double PetFoodQty { get; set; }
        public double PetFoodPrice { get; set; }
        public double TotalPrice { get; set; }
        #endregion Properties

        #region Relations

        [Required]
        public Guid CustomerID { get; set; }
        public Customer Customer { get; set; } = null!;

        [Required]
        public Guid EmployeeID { get; set; }
        public Employee Employee { get; set; } = null!;

        [Required]
        public Guid PetID { get; set; }
        public Pet Pet { get; set; } = null!;

        [Required]
        public Guid PetFoodID { get; set; }
        public List<PetFood> PetFoods { get; set; } = null!;

        #endregion Relations


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
