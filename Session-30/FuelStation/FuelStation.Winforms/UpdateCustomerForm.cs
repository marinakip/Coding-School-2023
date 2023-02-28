using FuelStation.Model.Entities;
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
using System.Xml.Linq;

namespace FuelStation.Winforms {
    public partial class UpdateCustomerForm : Form {
        private CustomerService _customerService = new();
        public CustomerListDto SelectedCustomer { get; set; }

        public UpdateCustomerForm() {
            InitializeComponent();
        }

        public UpdateCustomerForm(CustomerListDto selectedCustomer) {
            InitializeComponent();
            SelectedCustomer = selectedCustomer;
            txtBoxName.Text = selectedCustomer.Name;
            txtBoxSurname.Text = selectedCustomer.Surname;
        }


        private void UpdateCustomerForm_Load(object sender, EventArgs e) {

        }

        private async void btnOK_Click(object sender, EventArgs e) {
            CustomerEditDto updatedCustomer = new CustomerEditDto {
                Id= SelectedCustomer.Id,    
                Name = txtBoxName.Text,
                Surname = txtBoxSurname.Text,
                CardNumber = SelectedCustomer.CardNumber
            };
            try {
                await _customerService.UpdateCustomer(updatedCustomer);
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show($"Error in Update Customer {ex.Message}");
                throw new Exception(ex.Message);
            }

        }
    }
}
