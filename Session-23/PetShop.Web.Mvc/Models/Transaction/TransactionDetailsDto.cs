using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Web.Mvc.Models.Transaction {
    public class TransactionDetailsDto {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        [Display(Name = "Pet Price")]
        [Precision(4, 2)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Pet Price is required")]
        public decimal PetPrice { get; set; }

        [Display(Name = "Pet Food Quantity")]
        [Precision(4, 2)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Pet Price is required")]
        public int PetFoodQty { get; set; }

        [Display(Name = "Pet Food Price")]
        [Precision(4, 2)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Pet Food Price is required")]
        public decimal PetFoodPrice { get; set; }

        [Display(Name = "Total Price")]
        [Precision(4, 2)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Total Price is required")]
        public decimal TotalPrice { get; set; }

        public int CustomerId { get; set; }
        public Model.Customer Customer { get; set; } = null!;

        public int EmployeeId { get; set; }
        public Model.Employee Employee { get; set; } = null!;

        public int PetId { get; set; }
        public Model.Pet Pet { get; set; } = null!;

        public int PetFoodId { get; set; }
        public Model.PetFood PetFood { get; set; } = null!;
    }
}
