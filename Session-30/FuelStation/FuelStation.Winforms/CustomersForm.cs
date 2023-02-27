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
    public partial class CustomersForm : Form {
        private CustomerService _customerService = new();
        public CustomersForm() {
            InitializeComponent();
        }

        protected async void CustomersForm_Load(object sender, EventArgs e) {
            await LoadCustomersAsync();
        }
        
        //private void CustomersForm_Load(object sender, EventArgs e) {
           
        //}

        private async Task LoadCustomersAsync() {
            try {
                IEnumerable<CustomerListDto> customers = await _customerService.GetCustomers();
                grvCustomers.DataSource = customers.ToList();
            } catch (Exception ex) {
                // TODO: Handle the exception.
                MessageBox.Show($"Error loading customers: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            this.Close();  //TODO: This is not a good flow
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
