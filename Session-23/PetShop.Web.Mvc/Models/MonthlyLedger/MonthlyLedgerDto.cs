using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Web.Mvc.Models.MonthlyLedger {
    public class MonthlyLedgerDto {

        [Required]
        public int Year { get; set; }

        [Required]
        public Month Month { get; set; }

        [Precision(6, 2)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Income is required")]
        public decimal Income { get; set; }

        [Precision(6, 2)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Income is required")]
        public decimal Expenses { get; set; }

        [Display(Name ="Total Profit")]
        [Precision(6, 2)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Income is required")]
        public decimal Total { get; set; }

    }
}
