using FuelStation.Web.Blazor.Shared.TransactionLineDataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Winforms.Services {
    public class TransactionLineService {
        private readonly HttpClient _httpClient;
        public TransactionLineService() {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<TransactionLineListDto>> GetTransactionLines() {

            try {
                var response = await _httpClient.GetAsync("http://localhost:5061/transactionLine");
                var transactionLineList = await response.Content.ReadAsAsync<List<TransactionLineListDto>>();
                return transactionLineList;
            } catch (Exception ex) {
                MessageBox.Show($"Error in GetTransactionLines: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task<TransactionLineEditDto> GetTransactionLineById(Guid Id) {
            try {
                var response = await _httpClient.GetAsync($"http://localhost:5061/transactionLine/{Id}");
                var transactionLine = await response.Content.ReadAsAsync<TransactionLineEditDto>();
                return transactionLine;

            } catch (Exception ex) {
                MessageBox.Show($"Error in GetTransactionLineById: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task AddTransactionLine(TransactionLineCreateDto transactionLine) {
            HttpResponseMessage? response = null;
            response = await _httpClient.PostAsJsonAsync("http://localhost:5061/transactionLine/", transactionLine);
            try {
                response.EnsureSuccessStatusCode();
            } catch (Exception ex) {
                MessageBox.Show($"Error in AddTransactionLine: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateTransactionLine(TransactionLineEditDto transactionLine) {
            HttpResponseMessage? response = null;
            response = await _httpClient.PutAsJsonAsync("http://localhost:5061/transactionLine/", transactionLine);
            try {
                response.EnsureSuccessStatusCode();
            } catch (Exception ex) {
                MessageBox.Show($"Error in UpdateTransactionLine: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteTransactionLine(TransactionLineListDto transactionLine) {
            DialogResult result = MessageBox.Show($"Delete transactionLine for {transactionLine.ItemDescription} {transactionLine.TotalValue}. Are you sure?", "Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) {
                try {
                    var response = await _httpClient.DeleteAsync($"http://localhost:5061/transactionLine/{transactionLine.Id}");
                    response.EnsureSuccessStatusCode();
                } catch (Exception ex) {
                    MessageBox.Show($"Error in DeleteTransactionLine: {ex.Message}");
                    throw new Exception(ex.Message);
                }
            } else {
                MessageBox.Show($"Delete TransactionLine was Canceled");
            }
        }

    }
}
