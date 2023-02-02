using Session_16.Model.old_session_11_files;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Model {

    public class Transaction {

        #region Properties
        public Guid TransactionID { get; set; }

        [Required]
        public List<TransactionLine> TransactionLines { get; set; } 

        [Required]
        public DateTime TransactionDate { get; set; }       
        public double TotalPrice { get; set; }
        #endregion Properties

        #region Relations        
        public Guid CustomerID { get; set; }
        public Customer Customer { get; set; } = null!;
        
        public Guid EmployeeID { get; set; }
        public Employee Employee { get; set; } = null!;

        

        #endregion Relations

        public Transaction(Guid customerID, Guid employeeID) {
            TransactionID = Guid.NewGuid();
            TransactionDate = DateTime.Now;
            CustomerID = customerID;
            EmployeeID = employeeID;
            TransactionLines = new List<TransactionLine>(); 
           
        }    
    }
}
