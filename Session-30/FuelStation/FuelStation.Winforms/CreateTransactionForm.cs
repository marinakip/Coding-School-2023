using FuelStation.Web.Blazor.Shared.CustomerDataTransferObjects;
using FuelStation.Web.Blazor.Shared.EmployeeDataTranferObjects;
using FuelStation.Web.Blazor.Shared.TransactionDataTranferObjects;
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
    public partial class CreateTransactionForm : Form {
        private TransactionService _transactionService = new();
        private CustomerService _customerService = new();
        private EmployeeService _employeeService = new();
        private TransactionListDto _selectedTransaction { get; set; }
        private TransactionEditDto _updatedTransaction = new();
        private List<CustomerListDto> _customers = new();
        private List<EmployeeListDto> _employees = new();
        public CreateTransactionForm() {
            InitializeComponent();
        }

       

        private void comboBoxEmployeeSurname_SelectedIndexChanged(object sender, EventArgs e) {
            
        }


        private void btnSearchCustomer_Click(object sender, EventArgs e) {
            SearchCustomerForm searchCustomerForm = new SearchCustomerForm();
            if (searchCustomerForm.ShowDialog() == DialogResult.OK) {
                var customer = searchCustomerForm.FoundCustomer;
                if (customer != null) {
                    textBoxCustomerSurname.Text = $"{customer.Surname}";
                    textBoxCustomerName.Text = $"{customer.Name}";
                } else {
                    MessageBox.Show("Customer doesn't exist. Proceed to create New Customer");
                    CreateCustomerForm createCustomerForm = new CreateCustomerForm();
                    createCustomerForm.ShowDialog();
                }
            }
        }

        private void textBoxEmployeeName_TextChanged(object sender, EventArgs e) {
            
        }

        private void textBoxCustomerSurname_TextChanged(object sender, EventArgs e) {
           
        }

        private void textBoxCustomerName_TextChanged(object sender, EventArgs e) {
           
        }

        private void btnOK_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private async void CreateTransactionForm_Load(object sender, EventArgs e) {
            await LoadCustomersAsync();
            await LoadEmployeesAsync();
        }


        private async Task LoadCustomersAsync() {
            try {
                IEnumerable<CustomerListDto> customers = await _customerService.GetCustomers();
                _customers = customers.ToList();
            } catch (Exception ex) {
                MessageBox.Show($"Error loading customers: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }
        private async Task LoadEmployeesAsync() {
            try {
                IEnumerable<EmployeeListDto> employees = await _employeeService.GetEmployees();
                _employees = employees.ToList();
            } catch (Exception ex) {
                MessageBox.Show($"Error loading employees: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }
    }
}
