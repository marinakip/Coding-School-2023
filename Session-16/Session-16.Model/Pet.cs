using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Session_16.Model.old_session_11_files.Pet;

namespace Session_16.Model {
    public class Pet {
        public enum AnimalType {
            Bird,
            Cat,
            Dog
        }
        public enum PetStatus {
            OK,
            Unhealthy,
            Recovering
        }

        public Guid PetID { get; set; }

        [Required]
        public string Breed { get; set; }

        [Required]  
        public AnimalType Type { get; set; }

        [Required]  
        public PetStatus Status { get; set; }
        public double Price { get; set; }
        public double Cost { get; set; }

        public Pet(string breed, AnimalType type, PetStatus status) {
            PetID= Guid.NewGuid();  
            Breed= breed;
            Type= type;
            Status= status; 
        }

        public Pet(Guid petID, string breed, AnimalType animalType, PetStatus status, double price, double cost) {
            PetID = petID;
            Breed = breed;
            Type = animalType;
            Status = status;
            Price = price;
            Cost = cost;
        }



    }
}
