using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Model {
    public class Customer {
        public Guid CustomerID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Phone { get; set; }

        public string TIN { get; set; }

        public Customer() {
            CustomerID = Guid.NewGuid();
        }

        public Customer(Guid customerID, string name, string surname, string phone, string tIN) {
            CustomerID = customerID;
            Name = name;
            Surname = surname;
            Phone = phone;
            TIN = tIN;
        }
    }
}
