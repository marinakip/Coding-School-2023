using FuelStation.Model.Entities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FuelStation.Winforms {
    public partial class CreateTransactionForm : Form {
        
        private EmployeeService _employeeService = new();
        private List<EmployeeListDto> _employees = new();
        private EmployeeListDto _selectedEmployee = new();



        public CreateTransactionForm() {
            InitializeComponent();
        }


        private void comboBoxEmployeeSurname_SelectedIndexChanged(object sender, EventArgs e) {
            string selectedSurname = comboBoxEmployeeSurname.SelectedItem.ToString();
            _selectedEmployee = _employees.FirstOrDefault(employee => employee.Surname == selectedSurname);
            if (_selectedEmployee != null) {
                textBoxEmployeeName.Text = _selectedEmployee.Name;
                textBoxEmployeeName.Enabled = false;
                
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e) {
            SearchCustomerForm searchCustomerForm = new SearchCustomerForm();
            if (searchCustomerForm.ShowDialog() == DialogResult.OK) {
                var customer = searchCustomerForm.FoundCustomer;
                if (customer != null) {
                    textBoxCustomerSurname.Text = $"{customer.Surname}";
                    textBoxCustomerSurname.Enabled = false;
                    textBoxCustomerName.Text = $"{customer.Name}";
                    textBoxCustomerName.Enabled = false;
                } else {
                    MessageBox.Show("Customer doesn't exist. Proceed to create New Customer");
                    CreateCustomerForm createCustomerForm = new CreateCustomerForm();
                    createCustomerForm.ShowDialog();
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            CreateTransactionLineForm createTransactionLineForm = new CreateTransactionLineForm();
            createTransactionLineForm.ShowDialog();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private async void CreateTransactionForm_Load(object sender, EventArgs e) {
            await LoadEmployeesAsync();
            comboBoxEmployeeSurname.Items.AddRange(_employees.Select(employee => employee.Surname).ToArray());
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
