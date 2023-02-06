using Session_16.Orm.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_16 {

    // I want to use Session-16.Business PetShop methods here that use generics
    public partial class CustomersForm : Form {
        private CustomerRepository? _customerRepository;
        public CustomersForm() {
            InitializeComponent();
        }
        private void CustomersForm_Load(object sender, EventArgs e) {
            _customerRepository = new CustomerRepository();
            RefreshCustomers();
            
        }

        private void RefreshCustomers() {
            throw new NotImplementedException();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
           
        }

       

    }
}
