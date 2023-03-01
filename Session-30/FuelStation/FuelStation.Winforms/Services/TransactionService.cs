using FuelStation.Web.Blazor.Shared.TransactionDataTranferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Winforms.Services {
    public class TransactionService {
        private readonly HttpClient _httpClient;
        public TransactionService() {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<TransactionListDto>> GetTransactions() {

            try {
                var response = await _httpClient.GetAsync("http://localhost:5061/transaction");
                var transactionList = await response.Content.ReadAsAsync<List<TransactionListDto>>();
                return transactionList;
            } catch (Exception ex) {
                MessageBox.Show($"Error in GetTransactions: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task<TransactionEditDto> GetTransactionById(Guid Id) {
            try {
                var response = await _httpClient.GetAsync($"http://localhost:5061/transaction/{Id}");
                var transaction = await response.Content.ReadAsAsync<TransactionEditDto>();
                return transaction;

            } catch (Exception ex) {
                MessageBox.Show($"Error in GetTransactionById: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task AddTransaction(TransactionCreateDto transaction) {
            HttpResponseMessage? response = null;
            response = await _httpClient.PostAsJsonAsync("http://localhost:5061/transaction/", transaction);
            try {
                response.EnsureSuccessStatusCode();
            } catch (Exception ex) {
                MessageBox.Show($"Error in AddTransaction: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateTransaction(TransactionEditDto transaction) {
            HttpResponseMessage? response = null;
            response = await _httpClient.PutAsJsonAsync("http://localhost:5061/transaction/", transaction);
            try {
                response.EnsureSuccessStatusCode();
            } catch (Exception ex) {
                MessageBox.Show($"Error in UpdateTransaction: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteTransaction(TransactionListDto transaction) {
            DialogResult result = MessageBox.Show($"Delete transaction {transaction.Date} {transaction.CustomerSurname} {transaction.CustomerName}. Are you sure?", "Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) {
                try {
                    var response = await _httpClient.DeleteAsync($"http://localhost:5061/transaction/{transaction.Id}");
                    response.EnsureSuccessStatusCode();
                } catch (Exception ex) {
                    MessageBox.Show($"Error in DeleteTransaction: {ex.Message}");
                    throw new Exception(ex.Message);
                }
            } else {
                MessageBox.Show($"Delete Transaction was Canceled");
            }
        }

    }
}
