using FuelStation.Web.Blazor.Shared.CustomerDataTransferObjects;
using FuelStation.Winforms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Winforms {
    public partial class CreateCustomerForm : Form {
        private CustomerService _customerService = new();
        public CreateCustomerForm() {
            InitializeComponent();
        }

        private async void btnOK_ClickAsync(object sender, EventArgs e) {
            CustomerCreateDto newCustomer = new CustomerCreateDto();
            newCustomer.Name = txtBoxName.Text;
            newCustomer.Surname = txtBoxSurname.Text;
            try {
                await _customerService.AddCustomer(newCustomer);
                this.Close();
            } catch (Exception ex){
                MessageBox.Show($"Error in Create New Customer {ex.Message}");
                throw new Exception(ex.Message );
            }           
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
