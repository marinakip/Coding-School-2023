using Microsoft.VisualBasic;
using Session_26.Shared;
using System.Net.Http.Json;

namespace Session_26.Client.States
{
// Tutorial Description of this class
//This cart service will hold the information about the product which is selected by the user.
//This is also known as storing the website's state. the website's state is stored in the memory.
    public class CartState {
        private readonly HttpClient _httpClient;
        public List<Product> SelectedItems { get; set; } = new();

        public CartState(HttpClient httpClient) {
            _httpClient = httpClient;
        }

        public async Task AddProductToCartAsync(int productId) {
            if(SelectedItems.Any(product => product.Id == productId) is false) {
                var products = await _httpClient.GetFromJsonAsync<List<Product>>("sample-data/products.json") ?? new();
                var product = products.First(product => product.Id == productId);
                SelectedItems.Add(product);
            }
        }
    }
}
