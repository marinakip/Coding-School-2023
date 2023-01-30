using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Model.old_session_11_files
{
    public class Employee : Person
    {
        public enum EmployeeTypeEnum
        {
            Manager,
            Staff
        }
        public Guid EmployeeID { get; set; }
        public double SalaryPerMonth { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }

        public string FullName
        {
            get { return string.Format("{0} {1}", Name, Surname); }
        }

        public Employee()
        {
            EmployeeID = Guid.NewGuid();
        }


        public Employee(Guid employeeID, string name, string surname, double salaryPerMonth, EmployeeTypeEnum employeeType) : base(name, surname)
        {
            EmployeeID = employeeID;
            SalaryPerMonth = salaryPerMonth;
            EmployeeType = employeeType;
        }
    }
}
