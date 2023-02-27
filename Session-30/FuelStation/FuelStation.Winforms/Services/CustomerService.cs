using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using FuelStation.Model.Entities;
using FuelStation.Web.Blazor.Shared.CustomerDataTransferObjects;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using Microsoft.JSInterop;
using FuelStation.Web.Blazor.Shared.EmployeeDataTranferObjects;

namespace FuelStation.Winforms.Services {
    public class CustomerService {
        private readonly HttpClient _httpClient;
        public CustomerService() {
            _httpClient = new HttpClient();
            // _httpClient.BaseAddress = new Uri("https://localhost:7292/");
            // _httpClient.BaseAddress = new Uri("http://localhost:5061/");            
            // _httpClient.DefaultRequestHeaders.Accept.Clear();
            // _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<IEnumerable<CustomerListDto>> GetCustomers() {

            try {
                var response = await _httpClient.GetAsync("https://localhost:7292/customer");
                var customerList = await response.Content.ReadAsAsync<List<CustomerListDto>>();
                // List<CustomerListDto> customerList = await _httpClient.GetFromJsonAsync<List<CustomerListDto>>("customer");
                return customerList;
            } catch (Exception ex) {
                //TODO: Go to error page
                //TODO: Implement Error Page
                MessageBox.Show($"Error in GetCustomers: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task<CustomerEditDto> GetCustomerById(Guid Id) {
            try {
               CustomerEditDto customer = await _httpClient.GetFromJsonAsync<CustomerEditDto>($"customer/{Id}");
                return customer;
            } catch (Exception ex) {
                MessageBox.Show($"Error in GetCustomerById: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task AddCustomer(CustomerCreateDto customer) {
            HttpResponseMessage? response = null;
            response = await _httpClient.PostAsJsonAsync("customer", customer);
            try {
                response.EnsureSuccessStatusCode();                
            } catch (Exception ex) {
                MessageBox.Show($"Error in AddCustomer: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateCustomer(CustomerEditDto customer) {
            HttpResponseMessage? response = null;
            response = await _httpClient.PutAsJsonAsync("customer", customer);
            try {
                response.EnsureSuccessStatusCode();
            } catch (Exception ex) {
                MessageBox.Show($"Error in AddCustomer: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        private async Task DeleteCustomer(CustomerListDto customer) {
            DialogResult result = MessageBox.Show($"Delete customer {customer.Name} {customer.Surname}. Are you sure?", "Confirmation", MessageBoxButtons.OKCancel);
           
            if (result == DialogResult.OK) {                               
                try {
                    var response = await _httpClient.DeleteAsync($"customer/{customer.Id}");
                    response.EnsureSuccessStatusCode();
                } catch (Exception ex) {
                    MessageBox.Show($"Error in DeleteCustomer: {ex.Message}");
                    throw new Exception(ex.Message);
                }
            } else {
                MessageBox.Show($"Delete Customer was Canceled");
            }
        }

    }
}
