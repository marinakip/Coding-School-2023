using FuelStation.Model.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared.EmployeeDataTranferObjects {
    public class EmployeeListDto {
        public Guid Id { get; set; }

        [MaxLength(50, ErrorMessage = "You have exceeded the limit of 50 characters")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        public string Name { get; set; } = null!;

        [MaxLength(100, ErrorMessage = "You have exceeded the limit of 100 characters")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Surname is required")]
        public string Surname { get; set; } = null!;

        [Display(Name = "Hire Date Start")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Hire Date Start is required")]
        public DateTime? HireDateStart { get; set; }

        [Display(Name = "Hire Date End")]
        public DateTime? HireDateEnd { get; set; }

        [Display(Name = "Sallary Per Month")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Sallary Per Month is required")]
        [RegularExpression(@"^\d{0,5}(\.\d{1,2})?$", ErrorMessage = "Please enter a number for Sallary Per Month with up to 2 decimal places and up to 7 total digits.")]
        public decimal SallaryPerMonth { get; set; }

        [Display(Name = "Employee Type")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Employee Type is required")]
        public EmployeeType EmployeeType { get; set; }      
    }
}
