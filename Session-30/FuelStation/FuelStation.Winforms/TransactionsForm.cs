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
    public partial class TransactionsForm : Form {
        private TransactionService _transactionService = new();
        public TransactionsForm() {
            InitializeComponent();
        }


        private async void TransactionsForm_Load(object sender, EventArgs e) {
            await LoadTransactionsAsync();
        }

        private async Task LoadTransactionsAsync() {
            try {
                IEnumerable<TransactionListDto> transactions = await _transactionService.GetTransactions();
                grvTransactions.DataSource = transactions.ToList();
            } catch (Exception ex) {
                MessageBox.Show($"Error loading transactions: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e) {
            //TODO SEARCH CUSTOMER
        }

        private void btnRefreshList_Click(object sender, EventArgs e) {
            RefreshTransactionList();
        }

        private async void RefreshTransactionList() {
            IEnumerable<TransactionListDto> transactions = await _transactionService.GetTransactions();
            grvTransactions.DataSource = transactions.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            TransactionListDto selectedTransaction = GetSelectedTransaction();
            UpdateTransactionForm updateTransactionForm = new UpdateTransactionForm(selectedTransaction);
            updateTransactionForm.ShowDialog();
        }

        private TransactionListDto GetSelectedTransaction() {
            try {
                DataGridViewRow selectedRow = grvTransactions.SelectedRows[0];
                TransactionListDto selectedTransaction = (TransactionListDto)selectedRow.DataBoundItem;
                return selectedTransaction;
            } catch (Exception ex) {
                MessageBox.Show("You should select a row first");
                throw new Exception(ex.Message);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e) {
            TransactionListDto selectedTransaction = GetSelectedTransaction();
            await _transactionService.DeleteTransaction(selectedTransaction);
            RefreshTransactionList();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            CreateTransactionForm createTransactionForm = new CreateTransactionForm();
            createTransactionForm.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}
