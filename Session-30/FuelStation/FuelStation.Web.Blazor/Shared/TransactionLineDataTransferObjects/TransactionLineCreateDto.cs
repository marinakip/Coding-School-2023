using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FuelStation.Web.Blazor.Shared.TransactionLineDataTransferObjects {
    public class TransactionLineCreateDto {

        // All the other properties are generated in the constructor, so they don't need here
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Quantity is required")]
        public int Quantity { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Discount Percent is required")]
        [Display(Name = "Discount Percent")]
        public decimal DiscountPercent { get; set; }

        //Relations 

        [Required(AllowEmptyStrings = false, ErrorMessage = "Transaction Id is required")]
        [Display(Name = "Transaction Id")]
        public Guid TransactionId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Item Id is required")]
        [Display(Name = "Item Id")]
        public Guid ItemId { get; set; }

        //TODO: Annotations for number validation
    }
}
