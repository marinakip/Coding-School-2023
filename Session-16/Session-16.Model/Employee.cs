using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Session_16.Model.old_session_11_files.Employee;

namespace Session_16.Model {
    public class Employee {
        public enum EmployeeType {
            Manager,
            Staff
        }

        public Guid EmployeeID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]  
        public EmployeeType TypeEmployee { get; set; }
        public double SalaryPerMonth { get; set; }

        public Employee(String name, String surname, EmployeeType typeEmployee) {
            EmployeeID = Guid.NewGuid();
            Name = name;
            Surname = surname;
            TypeEmployee = typeEmployee;
        }
        public Employee(String name, String surname, EmployeeType typeEmployee, double salaryPerMonth) {
            EmployeeID = Guid.NewGuid();
            Name = name;
            Surname = surname;
            TypeEmployee = typeEmployee;
            SalaryPerMonth = salaryPerMonth;
        }
    }
}
