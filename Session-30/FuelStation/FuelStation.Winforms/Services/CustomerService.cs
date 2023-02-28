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
        }

        public async Task<IEnumerable<CustomerListDto>> GetCustomers() {

            try {
                var response = await _httpClient.GetAsync("http://localhost:5061/customer");
                var customerList = await response.Content.ReadAsAsync<List<CustomerListDto>>();
                return customerList;
            } catch (Exception ex) {
                MessageBox.Show($"Error in GetCustomers: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task<CustomerEditDto> GetCustomerById(Guid Id) {
            try {
                //CustomerEditDto customer = await _httpClient.GetFromJsonAsync<CustomerEditDto>($"customer/{Id}");
                var response = await _httpClient.GetAsync($"http://localhost:5061/customer/{Id}");
                var customer = await response.Content.ReadAsAsync<CustomerEditDto>();
                return customer;             
                
            } catch (Exception ex) {
                MessageBox.Show($"Error in GetCustomerById: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task AddCustomer(CustomerCreateDto customer) {
            HttpResponseMessage? response = null;            
            response = await _httpClient.PostAsJsonAsync("http://localhost:5061/customer/", customer);
            try {
                response.EnsureSuccessStatusCode();                
            } catch (Exception ex) {
                MessageBox.Show($"Error in AddCustomer: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateCustomer(CustomerEditDto customer) {
            HttpResponseMessage? response = null;           
            response = await _httpClient.PutAsJsonAsync("http://localhost:5061/customer/", customer);
            try {
                response.EnsureSuccessStatusCode();
            } catch (Exception ex) {
                MessageBox.Show($"Error in UpdateCustomer: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteCustomer(CustomerListDto customer) {
            DialogResult result = MessageBox.Show($"Delete customer {customer.Name} {customer.Surname}. Are you sure?", "Confirmation", MessageBoxButtons.OKCancel);
           
            if (result == DialogResult.OK) {                               
                try {                    
                    var response = await _httpClient.DeleteAsync($"http://localhost:5061/customer/{customer.Id}");
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
