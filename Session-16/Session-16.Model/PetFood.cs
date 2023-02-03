using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Session_16.Model.old_session_11_files.Pet;

namespace Session_16.Model {
    public enum AnimalType {
        Bird,
        Cat,
        Dog
    }
    public class PetFood {
        public Guid PetFoodID { get; set; }

        [Required]
        public AnimalType AnimalType { get; set; }        
        public double PetFoodPrice { get; set; }        
        public double PetFoodCost { get; set; }

        #region Relations
        public TransactionLine TransactionLine { get; set; } = null!;        
        #endregion Relations

        public PetFood(AnimalType animalType) {
            PetFoodID = Guid.NewGuid();
            AnimalType = animalType;
        }
        
    }
}
