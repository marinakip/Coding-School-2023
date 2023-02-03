using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Model {
    public class SpecialOffer {
        public Guid SpecialOfferID { get; set; }

        #region Relations        
        public TransactionLine TransactionLine { get; set; }    
        #endregion Relations
        public SpecialOffer() {
            SpecialOfferID = Guid.NewGuid();            
        }   
    }
}
