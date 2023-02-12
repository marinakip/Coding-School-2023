using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Web.Mvc.Models.MonthlyLedger {
    public class MonthlyLedgerDto {

        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Year is required")]
        public int Year { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Month is required")]
        public Month Month { get; set; }

        [Precision(6, 2)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Income is required")]
        public decimal Income { get; set; }

        [Precision(6, 2)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Expenses is required")]
        public decimal Expenses { get; set; }

        [Display(Name ="Total Profit")]
        [Precision(6, 2)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Total Profit is required")]
        public decimal Total { get; set; }

    }
}
