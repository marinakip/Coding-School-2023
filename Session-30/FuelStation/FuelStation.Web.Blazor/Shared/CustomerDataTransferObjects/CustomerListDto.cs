using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared.CustomerDataTransferObjects {
    public class CustomerListDto {
        public Guid Id { get; set; }

        [MaxLength(50, ErrorMessage = "You have exceeded the limit of 50 characters")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        public string Name { get; set; } = null!;

        [MaxLength(100, ErrorMessage = "You have exceeded the limit of 100 characters")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Surname is required")]
        public string Surname { get; set; } = null!;

        [Display(Name = "Loyalty Card Number")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Loyalty Card Number is required")]
        public string CardNumber { get; set; } = null!;
    }
}
