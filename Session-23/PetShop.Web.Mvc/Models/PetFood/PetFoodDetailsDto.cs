using Microsoft.EntityFrameworkCore;
using PetShop.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Web.Mvc.Models.PetFood {
    public class PetFoodDetailsDto {
        public int Id { get; set; }

        [Display(Name = "Animal Type")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Animal type is required")]
        public AnimalType AnimalType { get; set; }

        [Precision(4, 2)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Price is required")]
        public decimal Price { get; set; }

        [Precision(4, 2)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Cost is required")]
        public decimal Cost { get; set; }

        public List<Model.Transaction> Transactions { get; set; } = new List<Model.Transaction>();
    }
}
