using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Model {
    
    public class TransactionLine {

        #region Properties
        public Guid TransactionLineID { get; set; }

        [Required]
        public int PetFoodQty { get; set; }

        [Required]  
        public double PetFoodCost { get; set; } 
        public double PetFoodPrice { get; set; }

        [Required]
        public double PetPrice { get; set; }
        public double LineTotal { get; set; }   
        #endregion Properties

        #region Relations
        public Guid TransactionID { get; set; }
        public Transaction Transaction { get; set; } = null!;
        public Guid PetFoodID { get; set; }
        public PetFood PetFood { get; set; } = null!;
        public Guid PetID { get; set; } 
        public Pet Pet { get; set; } = null!;   
        public Guid SpecialOfferID { get; set; }    
        public SpecialOffer SpecialOffer { get; set; } = null!;

        #endregion Relations
        public TransactionLine(int petFoodQty, double petFoodCost, double petPrice) {
            PetFoodQty = petFoodQty;
            PetFoodCost = petFoodCost;
            PetPrice = petPrice;
            PetFoodPrice = PetFoodQty * PetFoodCost;
            LineTotal = PetPrice + PetFoodPrice;
        }    
    }
}
