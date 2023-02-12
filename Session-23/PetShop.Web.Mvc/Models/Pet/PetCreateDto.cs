using Microsoft.EntityFrameworkCore;
using PetShop.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Web.Mvc.Models.Pet {
    public class PetCreateDto {

        [MaxLength(50, ErrorMessage = "You have exceeded the limit of 50 characters")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Breed is required")]
        public string Breed { get; set; } = null!;

        [Display(Name = "Animal Type")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Animal type is required")]
        public AnimalType AnimalType { get; set; }

        [Display(Name = "Pet Status")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Pet status is required")]
        public PetStatus PetStatus { get; set; }


        [RegularExpression("^\\d\\d,\\d\\d$", ErrorMessage ="Price should be in the format 12,34 and should not exceed 99,99")]
        [Precision(4, 2)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Price is required")]
        public decimal Price { get; set; }

        [RegularExpression("^\\d\\d,\\d\\d$", ErrorMessage = "Cost should be in the format 12,34 and should not exceed 99,99")]
        [Precision(4, 2)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Cost is required")]
        public decimal Cost { get; set; }
    }
}
