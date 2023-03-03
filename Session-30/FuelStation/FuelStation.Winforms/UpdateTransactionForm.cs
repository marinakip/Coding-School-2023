using FuelStation.Model.Enumerations;
using FuelStation.Web.Blazor.Client.Pages.Customer;
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
    public partial class UpdateTransactionForm : Form {
        private TransactionService _transactionService = new();
        private CustomerService _customerService = new();
        private EmployeeService _employeeService = new();  
        private TransactionListDto _selectedTransaction { get; set; }
        private TransactionEditDto _updatedTransaction = new();
        private List<CustomerListDto> _customers = new();
        private List<EmployeeListDto> _employees = new();
      
        public UpdateTransactionForm(TransactionListDto selectedTransaction) {
            _selectedTransaction = selectedTransaction;
            InitializeComponent();
        }

        private void comboBoxCustomerSurname_SelectedIndexChanged(object sender, EventArgs e) {
            _updatedTransaction.CustomerSurname = comboBoxCustomerSurname.SelectedItem.ToString();
        }

        private void comboBoxEmployeeSurname_SelectedIndexChanged(object sender, EventArgs e) {
            _updatedTransaction.EmployeeSurname = comboBoxEmployeeSurname.SelectedItem.ToString();
        }

        private void comboBoxCustomerName_SelectedIndexChanged(object sender, EventArgs e) {
            _updatedTransaction.CustomerName = comboBoxCustomerName.SelectedItem.ToString();
        }

        private void comboBoxEmployeeName_SelectedIndexChanged(object sender, EventArgs e) {
            _updatedTransaction.EmployeeName = comboBoxEmployeeName.SelectedItem.ToString();
        }

        private void comboBoxPaymentMethod_SelectedIndexChanged(object sender, EventArgs e) {
            PaymentMethod selectedPaymentMethod;
            if (Enum.TryParse(comboBoxPaymentMethod.SelectedItem.ToString(), out selectedPaymentMethod)) {
                _updatedTransaction.PaymentMethod = selectedPaymentMethod;
            } else {
                MessageBox.Show("This selection is invalid");
                throw new Exception("Selected payment method is not a valid PaymentMethod");
            }
        }

        private void textBoxTotalValue_TextChanged(object sender, EventArgs e) {

        }

        private async void btnOK_Click(object sender, EventArgs e) {
            _updatedTransaction.TotalValue = ConvertToDecimal(textBoxTotalValue.Text);

            try {
                await _transactionService.UpdateTransaction(_updatedTransaction);
                Close();
            } catch (Exception ex) {
                MessageBox.Show($"Error in Update Transaction {ex.Message}");
                throw new Exception(ex.Message);
            }
        }
    

        private decimal ConvertToDecimal(string text) {
            decimal number;
            if (decimal.TryParse(text, out number)) {
                return number;
            } else {
                MessageBox.Show($"Error in TryParse number, couldn't convert");
                throw new Exception("Error in TryParse number, couldn't convert");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private async void UpdateTransactionForm_Load(object sender, EventArgs e) {
            await LoadCustomersAsync();
            await LoadEmployeesAsync();
            comboBoxCustomerSurname.Text = _selectedTransaction.CustomerSurname;            
            comboBoxPaymentMethod.Items.AddRange(_customers.Select(customer => customer.Surname).ToArray()); 
            comboBoxCustomerName.Text = _selectedTransaction.CustomerName;
            comboBoxPaymentMethod.Items.AddRange(_customers.Select(customer => customer.Name).ToArray());
            comboBoxEmployeeSurname.Text = _selectedTransaction.EmployeeSurname;
            comboBoxPaymentMethod.Items.AddRange(_employees.Select(employee => employee.Surname).ToArray());
            comboBoxEmployeeName.Text = _selectedTransaction.EmployeeName;
            comboBoxPaymentMethod.Items.AddRange(_employees.Select(employee => employee.Name).ToArray());
            comboBoxPaymentMethod.Text = _selectedTransaction.PaymentMethod.ToString();
            comboBoxPaymentMethod.Items.AddRange(Enum.GetNames(typeof(PaymentMethod)));
            textBoxTotalValue.Text = _selectedTransaction.TotalValue.ToString();
            
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
