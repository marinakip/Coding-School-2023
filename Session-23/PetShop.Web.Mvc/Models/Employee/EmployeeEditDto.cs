using PetShop.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Web.Mvc.Models.Employee {
    public class EmployeeEditDto {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "You have exceeded the limit of 50 characters")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        public string Name { get; set; } = null!;

        [MaxLength(100, ErrorMessage = "You have exceeded the limit of 100 characters")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Surname is required")]
        public string Surname { get; set; } = null!;

        [Display(Name = " Employee Type")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Employee type is required")]
        public EmployeeType EmployeeType { get; set; }

        [Display(Name = " Salary Per Month")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Salary per month is required")]
        public int SalaryPerMonth { get; set; }
    }
}
