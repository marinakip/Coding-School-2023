using FuelStation.Model.Enumerations;
using FuelStation.Web.Blazor.Shared.CustomerDataTransferObjects;
using FuelStation.Web.Blazor.Shared.EmployeeDataTranferObjects;
using FuelStation.Web.Blazor.Shared.TransactionLineDataTransferObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FuelStation.Web.Blazor.Shared.TransactionDataTranferObjects {
    public class TransactionEditDto {
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }

        [Display(Name = "Payment method")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Payment Method is required")]
        public PaymentMethod PaymentMethod { get; set; }

        [Display(Name = "Total Value")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Total Value is required")]
        public decimal TotalValue { get; set; }

        [Display(Name = "Customer Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Customer Id is required")]
        public int CustomerId { get; set; }

        [Display(Name = "Customer Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Csutomer Name is required")]
        public string CustomerName { get; set; } = null!;

        [Display(Name = "Customer Surname")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Customer Surname is required")]
        public string CustomerSurname { get; set; } = null!;
        public List<CustomerListDto> Customers { get; set; } = new();

        [Display(Name = "Employee Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Employee Id is required")]
        public int EmployeeId { get; set; }

        [Display(Name = "Employee Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Employee Name is required")]
        public string EmployeeName { get; set; } = null!;

        [Display(Name = "Employee Surname")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Employee Surname is required")]
        public string EmployeeSurname { get; set; } = null!;
        public List<EmployeeListDto> Employees { get; set; } = new();

        public List<TransactionLineListDto> TransactionLines { get; set; } = new();
    }
}
