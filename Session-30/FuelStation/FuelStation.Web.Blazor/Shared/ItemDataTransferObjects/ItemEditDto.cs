using FuelStation.Model.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FuelStation.Web.Blazor.Shared.ItemDataTransferObjects {
    public class ItemEditDto {
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Code is required")]
        public string Code { get; set; } = null!;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Description is required")]
        [RegularExpression(@"\w.*", ErrorMessage = "Invalid Description.")]   //TODO: Needs additional validation to prevent user from sql injections 
        public string Description { get; set; } = null!;

        [Display(Name = "Item Type")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Item type is required")]
        public ItemType ItemType { get; set; }

        [RegularExpression(@"^\d{0,3}(\,\d{0,3})?$", ErrorMessage = "Enter a valid Price with up to 3 digits integer place and up to 3 decimal place. Use , not . for decimal")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Price is required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:0,0.00}")]
        public decimal Price { get; set; }

        [RegularExpression(@"^\d{0,3}(\,\d{0,3})?$", ErrorMessage = "Enter a valid Cost with up to 3 digits integer place and up to 3 decimal place.Use , not . for decimal")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Cost is required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:0,0.00}")]
        public decimal Cost { get; set; }

        //TODO: Custom validator for price when we have type fuel (3 decimals) and other product types (2 decimals)

    }
}

