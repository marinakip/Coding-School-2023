using FuelStation.Model.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FuelStation.Web.Blazor.Shared.ItemDataTransferObjects {
    public class ItemCreateDto {

        [Required(AllowEmptyStrings = false, ErrorMessage = "Description is required")]
        [RegularExpression("/^[a-zA-Z0-9 ]*$/", ErrorMessage ="Invalid Description. Only letters and numbers are allowed.")]
        public string Description { get; set; } = null!;

        [Display(Name = "Item Type")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Item type is required")]
        public ItemType ItemType { get; set; }

        //[RegularExpression(@"^\d{0,3}(\.\d{0,3})?$", ErrorMessage = "Please enter a number for Price with up to 3 decimal places and up to 6 total digits.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Price is required")]
        public decimal Price { get; set; }

       // [RegularExpression(@"^\d{0,3}(\.\d{0,3})?$", ErrorMessage = "Please enter a number for Cost with up to 3 decimal places and up to 6 total digits.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Cost is required")]
        public decimal Cost { get; set; }

    }
}
