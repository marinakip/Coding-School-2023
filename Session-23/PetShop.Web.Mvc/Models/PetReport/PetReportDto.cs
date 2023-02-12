using PetShop.Model.Enums;
using PetShop.Web.Mvc.Models.MonthlyLedger;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Web.Mvc.Models.PetReport {
    public class PetReportDto {

        [Required(AllowEmptyStrings = false, ErrorMessage = "Year is required")]
        public int Year { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Month is required")]
        public Month Month { get; set; }

        [Display(Name = "Animal Type")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Animal type is required")]
        public AnimalType TypeAnimal { get; set; }

        [Display(Name = "Total Sold")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Total Sold is required")]
        public int TotalSold { get; set; }
    }
}
