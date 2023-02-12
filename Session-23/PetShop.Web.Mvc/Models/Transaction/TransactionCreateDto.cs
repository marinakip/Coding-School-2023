using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace PetShop.Web.Mvc.Models.Transaction {
    public class TransactionCreateDto {
        //public DateTime Date { get; set; }    // We don't need that because the date is instantiated in Transaction constructor 

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

        [Display(Name = "Customer")]
        public int CustomerId { get; set; }
        //public Model.Customer Customer { get; set; } = null!;
        public List<SelectListItem> Customers { get; } = new List<SelectListItem>();

        [Display(Name = "Employee")]
        public int EmployeeId { get; set; }
        //public Model.Employee Employee { get; set; } = null!;
        public List<SelectListItem> Employees { get; } = new List<SelectListItem>();

        [Display(Name = "Pet")]
        public int PetId { get; set; }
        //public Model.Pet Pet { get; set; } = null!;
        public List<SelectListItem> Pets { get; } = new List<SelectListItem>();

        [Display(Name = "Pet Food")]
        public int PetFoodId { get; set; }
        //public Model.PetFood PetFood { get; set; } = null!;
        public List<SelectListItem> PetFoods { get; } = new List<SelectListItem>();
    }
}
