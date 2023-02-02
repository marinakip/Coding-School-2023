using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Model {
    public class SpecialOffer {
        public Guid SpecialOfferID { get; set; }

        #region Relations
        public Guid PetFoodID { get; set; }
        public double PetFoodPrice { get; set; }  // Maybe not needed
        public PetFood? PetFood { get; set; }
        #endregion Relations
        public SpecialOffer(Guid petFoodID) {
            SpecialOfferID = Guid.NewGuid();
            PetFoodID = petFoodID;
            PetFoodPrice = 0.0; // Maybe not needed
        }   
    }
}
