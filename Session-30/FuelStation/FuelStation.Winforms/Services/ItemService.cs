using FuelStation.Web.Blazor.Shared.ItemDataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Winforms.Services {
    public class ItemService {

        private readonly HttpClient _httpClient;
        public ItemService() {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<ItemListDto>> GetItems() {

            try {
                var response = await _httpClient.GetAsync("http://localhost:5061/item");
                var itemList = await response.Content.ReadAsAsync<List<ItemListDto>>();
                return itemList;
            } catch (Exception ex) {
                MessageBox.Show($"Error in GetItems: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task<ItemEditDto> GetItemById(Guid Id) {
            try {
                var response = await _httpClient.GetAsync($"http://localhost:5061/item/{Id}");
                var item = await response.Content.ReadAsAsync<ItemEditDto>();
                return item;

            } catch (Exception ex) {
                MessageBox.Show($"Error in GetItemById: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task AddItem(ItemCreateDto item) {
            HttpResponseMessage? response = null;
            response = await _httpClient.PostAsJsonAsync("http://localhost:5061/item/", item);
            try {
                response.EnsureSuccessStatusCode();
            } catch (Exception ex) {
                MessageBox.Show($"Error in AddItem: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateItem(ItemEditDto item) {
            HttpResponseMessage? response = null;
            response = await _httpClient.PutAsJsonAsync("http://localhost:5061/item/", item);
            try {
                response.EnsureSuccessStatusCode();
            } catch (Exception ex) {
                MessageBox.Show($"Error in UpdateItem: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteItem(ItemListDto item) {
            DialogResult result = MessageBox.Show($"Delete item {item.Code} {item.Description}. Are you sure?", "Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) {
                try {
                    var response = await _httpClient.DeleteAsync($"http://localhost:5061/item/{item.Id}");
                    response.EnsureSuccessStatusCode();
                } catch (Exception ex) {
                    MessageBox.Show($"Error in DeleteItem: {ex.Message}");
                    throw new Exception(ex.Message);
                }
            } else {
                MessageBox.Show($"Delete Item was Canceled");
            }
        }



    }
}
