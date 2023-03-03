using FuelStation.Web.Blazor.Shared.CustomerDataTransferObjects;
using FuelStation.Winforms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Winforms {
    public partial class SearchCustomerForm : Form {
        private CustomerService _customerService = new();
        private List<CustomerListDto> _customers = new();
        public CustomerListDto FoundCustomer = new();
        public SearchCustomerForm() {
            InitializeComponent();
        }

        private async void SearchCustomerForm_Load(object sender, EventArgs e) {
            await LoadCustomersAsync();
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

        private void btnSearch_Click(object sender, EventArgs e) {

            string cardNumber = textBoxCardNumber.Text;

            //BUG: It seems that in the database the card number is stored with an extra space in the end of the number
            // because it doesn't match with just the cardnumber, it needs a space in the end.

            //HACK: Instead of changing the model and the entire database with card number records,
            // Regex is going to be used to check for input and add the extra space if needed

            string pattern = @"^A\d{16}$";
            if(Regex.IsMatch(cardNumber, pattern)) {
                cardNumber = $"{cardNumber} "; //added extra space in the end of the string
            }

            try {
                FoundCustomer = _customers.FirstOrDefault(customer => customer.CardNumber == cardNumber);
                if(FoundCustomer != null ) {
                    MessageBox.Show($"Found Customer: {FoundCustomer.Surname} {FoundCustomer.Name}");
                } else {
                    MessageBox.Show($"Customer Not Found");
                }
                
            } catch (Exception ex) {
                MessageBox.Show($"Error in Card Number Search: {ex.Message}");
                throw new Exception(ex.Message);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void textBoxCardNumber_TextChanged(object sender, EventArgs e) {

        }
    }
}
