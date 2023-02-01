using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Model {
    public class MonthlyLedger : EntityBase {

        //public Guid MonthlyLedgerID { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int Month { get; set; }

        [Required]
        public double Income { get; set; }

        [Required]
        public double Expenses { get; set; }

        public double Total { get; set; }

        public MonthlyLedger( int year, int month, double income, double expenses) {
            //MonthlyLedgerID = Guid.NewGuid();
            Year = year;
            Month = month;
            Income = income;
            Expenses = expenses;
            Total = income - expenses;
        }
    }
}
