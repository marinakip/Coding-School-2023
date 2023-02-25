using FuelStation.Web.Blazor.Shared.ItemDataTransferObjects;
using FuelStation.Web.Blazor.Shared.TransactionDataTranferObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FuelStation.Web.Blazor.Shared.TransactionLineDataTransferObjects {
    public class TransactionLineEditDto {

        [Required(AllowEmptyStrings = false, ErrorMessage = "Id is required")]
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Quantity is required")]
        public int Quantity { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Item Price is required")]
        [Display(Name = "Item Price")]
        public decimal ItemPrice { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Net Value is required")]
        [Display(Name = "Net Value")]
        public decimal NetValue { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Discount Percent is required")]
        [Display(Name = "Discount Percent")]
        public decimal DiscountPercent { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Discount Value is required")]
        [Display(Name = "Discount Value")]
        public decimal DiscountValue { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Total Value is required")]
        [Display(Name = "Total Value")]
        public decimal TotalValue { get; set; }

        //Relations 

        [Required(AllowEmptyStrings = false, ErrorMessage = "Transaction Id is required")]
        [Display(Name = "Transaction Id")]
        public Guid TransactionId { get; set; }

        public List<TransactionListDto> Transactions { get; set; } = new();

        [Required(AllowEmptyStrings = false, ErrorMessage = "Item Id is required")]
        [Display(Name = "Item Id")]
        public Guid ItemId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Item Code is required")]
        [Display(Name = "Item Code")]
        public string ItemCode { get; set; }   

        [Required(AllowEmptyStrings = false, ErrorMessage = "Item Description is required")]
        [Display(Name = "Item Description")]
        public string ItemDescription { get; set; }

        public List<ItemListDto> Items { get; set; } = new();   

        //TODO: Annotations for number validation
    }
}
