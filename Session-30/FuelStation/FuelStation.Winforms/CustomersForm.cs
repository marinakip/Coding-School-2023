using FuelStation.Model.Entities;
using FuelStation.Web.Blazor.Shared.CustomerDataTransferObjects;
using FuelStation.Winforms.Services;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
    public partial class CustomersForm : Form {
        private CustomerService _customerService = new();
        public CustomersForm() {
            InitializeComponent();
        }

        protected async void CustomersForm_Load(object sender, EventArgs e) {
            await LoadCustomersAsync();
        }
        

        private async Task LoadCustomersAsync() {
            try {
                IEnumerable<CustomerListDto> customers = await _customerService.GetCustomers();
                grvCustomers.DataSource = customers.ToList();
            } catch (Exception ex) {
                MessageBox.Show($"Error loading customers: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            this.Close(); 
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void grvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e) {

          
        }

        private async void btnAdd_Click(object sender, EventArgs e) {
            CreateCustomerForm createCustomerForm = new CreateCustomerForm();
            createCustomerForm.ShowDialog();             
        }


        private async void btnDelete_Click(object sender, EventArgs e) {
            CustomerListDto selectedCustomer = GetSelectedCustomer();
            await _customerService.DeleteCustomer(selectedCustomer);            
            RefreshCustomerList();           
        }

        private CustomerListDto GetSelectedCustomer() {
            DataGridViewRow selectedRow = grvCustomers.SelectedRows[0];
            CustomerListDto selectedCustomer = (CustomerListDto)selectedRow.DataBoundItem;
            return selectedCustomer;
        }

        private async void btnUpdate_Click(object sender, EventArgs e) {
            CustomerListDto selectedCustomer = GetSelectedCustomer();
            UpdateCustomerForm updateCustomerForm = new UpdateCustomerForm(selectedCustomer);
            updateCustomerForm.ShowDialog();         
        }

        private void btnRefreshList_Click(object sender, EventArgs e) {
            RefreshCustomerList();
        }

        private async void RefreshCustomerList() {
            IEnumerable<CustomerListDto> customers = await _customerService.GetCustomers();
            grvCustomers.DataSource = customers.ToList();
        }
    }
}
