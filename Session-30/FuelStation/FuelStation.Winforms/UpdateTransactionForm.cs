using FuelStation.Model.Enumerations;
using FuelStation.Web.Blazor.Client.Pages.Customer;
using FuelStation.Web.Blazor.Shared.CustomerDataTransferObjects;
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
        //private EmployeeService _employeeService = new();  //TODO Employee Service
        private TransactionListDto _selectedTransaction { get; set; }
        private TransactionEditDto _updatedTransaction = new();
        private List<CustomerListDto> _customers = new();
      
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

        private void UpdateTransactionForm_Load(object sender, EventArgs e) {
            comboBoxCustomerSurname.Text = _selectedTransaction.CustomerSurname;            
            //comboBoxPaymentMethod.Items.AddRange(GetCustomersSurnames());  //TODO FIX IT IS WRONG
            comboBoxCustomerName.Text = _selectedTransaction.CustomerName;
            comboBoxPaymentMethod.Items.AddRange(GetCustomersNames());
            comboBoxEmployeeSurname.Text = _selectedTransaction.EmployeeSurname;
            comboBoxPaymentMethod.Items.AddRange(GetEmployeesSurnames());
            comboBoxEmployeeName.Text = _selectedTransaction.EmployeeName;
            comboBoxPaymentMethod.Items.AddRange(GetEmployeesNames());
            comboBoxPaymentMethod.Text = _selectedTransaction.PaymentMethod.ToString();
            comboBoxPaymentMethod.Items.AddRange(Enum.GetNames(typeof(PaymentMethod)));
            textBoxTotalValue.Text = _selectedTransaction.TotalValue.ToString();
            
        }

        //TODO: GetCustomersSurnames etc
        private async Task<string[]> GetCustomersSurnames() {
            await LoadCustomersAsync();
            string[] customerSurnames = _customers.Select(customer => customer.Surname).ToArray();
            return customerSurnames;
        }


        private string[] GetCustomersNames() {
            throw new NotImplementedException();
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

        private string[] GetEmployeesSurnames() {
            throw new NotImplementedException();
        }

        private string[] GetEmployeesNames() {
            throw new NotImplementedException();
        }



    }
}
