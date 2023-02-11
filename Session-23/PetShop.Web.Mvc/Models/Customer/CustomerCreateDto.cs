using System.ComponentModel.DataAnnotations;

namespace PetShop.Web.Mvc.Models.Customer {
    public class CustomerCreateDto {

        [MaxLength(50, ErrorMessage = "You have exceeded the limit of 50 characters")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        public string Name { get; set; } = null!;

        [MaxLength(100, ErrorMessage = "You have exceeded the limit of 100 characters")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Surname is required")]
        public string Surname { get; set; } = null!;

        [MaxLength(15, ErrorMessage = "You have exceeded the limit of 15 characters")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Phone is required")]
        public string Phone { get; set; } = null!;

        [MaxLength(30, ErrorMessage = "You have exceeded the limit of 30 characters")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tax Identification Number is required")]
        [Display(Name = "Tax Identification Number")]
        public string Tin { get; set; } = null!;
    }
}
