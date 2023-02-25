using FuelStation.Model.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FuelStation.Web.Blazor.Shared.EmployeeDataTranferObjects {
    public class EmployeeEditDto {
        public Guid Id { get; set; }

        [MaxLength(50, ErrorMessage = "You have exceeded the limit of 50 characters")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        [RegularExpression("^\\p{L}+(?: \\p{L}+)*$", ErrorMessage = "Please give a valid first name")]
        public string Name { get; set; } = null!;

        [MaxLength(100, ErrorMessage = "You have exceeded the limit of 100 characters")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Surname is required")]
        [RegularExpression("^\\p{L}+(?: \\p{L}+)*$", ErrorMessage = "Please give a valid last name")]
        public string Surname { get; set; } = null!;

        [Display(Name = "Hire Date Start")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Hire Date Start is required")]
        public DateTime? HireDateStart { get; set; }

        [Display(Name = "Hire Date End")]
        public DateTime? HireDateEnd { get; set; }

        [Display(Name = "Sallary Per Month")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Sallary Per Month is required")]
        [RegularExpression(@"^\d{0,5}(\,\d{0,2})?$", ErrorMessage = "Enter a valid Sallary Per Month with up to 5 integer places and up to 2 decimal places. Use , not .")]
        public decimal SallaryPerMonth { get; set; }

        [Display(Name = "Employee Type")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Employee Type is required")]
        public EmployeeType EmployeeType { get; set; }

        //TODO: Maybe use the same DTO for list and edit because they are the same
    }
}
