using Microsoft.EntityFrameworkCore;
using PetShop.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Web.Mvc.Models.Pet {
    public class PetEditDto {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "You have exceeded the limit of 50 characters")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Breed is required")]
        public string Breed { get; set; } = null!;

        [Display(Name = "Animal Type")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Animal type is required")]
        public AnimalType AnimalType { get; set; }

        [Display(Name = "Pet Status")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Pet status is required")]
        public PetStatus PetStatus { get; set; }

        [Precision(4, 2)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Price is required")]
        public decimal Price { get; set; }

        [Precision(4, 2)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Cost is required")]
        public decimal Cost { get; set; }
    }
}
