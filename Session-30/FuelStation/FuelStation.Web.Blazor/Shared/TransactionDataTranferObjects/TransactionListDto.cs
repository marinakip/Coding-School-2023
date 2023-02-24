using FuelStation.Model.Enumerations;
using FuelStation.Web.Blazor.Shared.CustomerDataTransferObjects;
using FuelStation.Web.Blazor.Shared.EmployeeDataTranferObjects;
using FuelStation.Web.Blazor.Shared.TransactionLineDataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared.TransactionDataTranferObjects {
    public class TransactionListDto {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }       
        public PaymentMethod PaymentMethod { get; set; }    
        public decimal TotalValue { get; set; }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;
        public string CustomerSurname { get; set; } = null!;       
        public List<CustomerListDto> Customers { get; set; } = new();

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = null!;
        public string EmployeeSurname { get; set; } = null!;        
        public List<EmployeeListDto> Employees { get; set; } = new();

        public List<TransactionLineListDto> TransactionLines { get; set; } = new();
    }
}
